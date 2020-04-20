using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SFF.Core.Context
{
    class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options)
        { }

        public DbSet<Movie> Movies { get; set; }
    }
}
