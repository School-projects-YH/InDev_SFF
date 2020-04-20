using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SFF.Core.MovieStudios;


namespace SFF.Core.Context
{
    public class MovieStudioContext : DbContext
    {
        public MovieStudioContext(DbContextOptions<MovieStudioContext> options) : base(options)
        { }
        public DbSet<MovieStudio> movieStudios { get; set; }
    }
}
