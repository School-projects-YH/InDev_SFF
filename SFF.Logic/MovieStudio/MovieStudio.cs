using System;
using System.Collections.Generic;
using SFF.Datasource.Model;

namespace SFF.Core.MovieStudios 
{
    public class MovieStudio : SFF.Datasource.Model.MovieStudio
    {
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
