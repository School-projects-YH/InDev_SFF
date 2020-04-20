using System;
using System.Collections.Generic;
using System.Text;
using SFF.Core.MovieStudios;
using Microsoft.EntityFrameworkCore;
using SFF.Core.Context;
using System.Linq;

namespace SFF.Core.Model
{
    public class MovieStudioRepository : IRepository<MovieStudio>
    {
        readonly MovieStudioContext _context;

        public MovieStudioRepository(MovieStudioContext context)
        {
            _context = context;
        }

        public IEnumerable<MovieStudio> List
        {
            get
            {
                return _context.movieStudios;
            }
        }
        public void Add(MovieStudio movie)
        {
            _context.movieStudios.Add(movie);
            _context.SaveChanges();
        }

        public void Delete(MovieStudio movie)
        {
            _context.movieStudios.Remove(movie);
            _context.SaveChanges();
        }

        public void Update(MovieStudio movie)
        {
            _context.Entry(movie).State =
               EntityState.Modified;
            _context.SaveChanges();
        }

        public MovieStudio FindById(int id)
        {
            var results =
                (from m in _context.movieStudios where m.Id == id select m)
                .FirstOrDefault();
            return results;

        }

    }
}
