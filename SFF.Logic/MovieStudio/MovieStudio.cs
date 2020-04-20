using System;
using System.Collections.Generic;
using SFF.Core.Model;
using SFF.Core;

namespace SFF.Core.MovieStudios 
{
    public class MovieStudio : IEntity
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }

        private MovieStudio()
        {

        }

        public MovieStudio(string Name, string City)
        {
            this.Name = Name;
            this.City = City;
        }

        public MovieStudio(string Name, string City, string Adress) : this (Name, City)
        {
            this.Adress = Adress;
        }

        public IEnumerable<Movie> CurrentlyRentedMovies()
        {
            throw new NotImplementedException();
            // Database connection

        }
    }
}
