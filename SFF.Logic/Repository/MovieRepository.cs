using System;
using System.Collections.Generic;
using System.Text;
using SFF.Core;
using Microsoft.EntityFrameworkCore;
using SFF.Core.Context;
using System.Linq;

namespace SFF.Core.Model
{
    class MovieRepository : IRepository<Movie>
    {
        private readonly MovieContext _context;

        public MovieRepository(MovieContext context)
        {
            this._context = context;
        }

        public IEnumerable<Movie> List
        {
            get
            {
                return _context.Movies;
            }
        }
        public void Add(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void Delete(Movie movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public void Update(Movie movie)
        {
            _context.Entry(movie).State =
               EntityState.Modified;
            _context.SaveChanges();
        }

        public Movie FindById(int id)
        {
            var results = 
                (from m in _context.Movies where m.Id == id select m)
                .FirstOrDefault();
            return results;

        }

    }
}
