using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SFF.Datasource.Model;


namespace SFF.Datasource.Context
{
    public class MovieStudioContext : DbContext
    {
        public MovieStudioContext(DbContextOptions<MovieStudioContext> options) : base(options)
        { }
        public DbSet<MovieStudio> MovieStudios { get; set; }
    }
}
