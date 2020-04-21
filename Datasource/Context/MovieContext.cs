using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SFF.Datasource.Model;

namespace SFF.Datasource.Context
{
    class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options)
        { }

        public DbSet<Movie> Movies { get; set; }
    }
}
