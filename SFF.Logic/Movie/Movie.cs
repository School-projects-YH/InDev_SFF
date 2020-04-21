﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using SFF.Datasource.Model;

namespace SFF.Core
{
    public class Movie : SFF.Datasource.Model.Movie
    {
        public Movie(string Title, decimal Duration)
        {
            MovieProperty = new MovieProperty
            {
                Title = Title,
                Duration = Duration.ToString(),

                // Standard value 10
                NumberOfMaxSimultaneouslyRented = 10
            };
        }
        public Movie(string Title, decimal Duration, int MaxSimultaneouslyRented) : this(Title, Duration)
        {
            MovieProperty.NumberOfMaxSimultaneouslyRented = MaxSimultaneouslyRented;
        }
        public void RentMovie(int numberOfMovies)
        {
            if (IsMaxRented(numberOfMovies))
            {
                MovieProperty.NumberOfCurrentlyRented = numberOfMovies;
            }
            else
            {
                var exceptionString = "Max number of rented movies reached already";
                throw new ExceedingMaxRentCapReachedException(exceptionString);
            }
        }
        private bool IsMaxRented(int numberOfRentedMovies) => MovieProperty.NumberOfCurrentlyRented + numberOfRentedMovies <= MovieProperty.NumberOfMaxSimultaneouslyRented;

    }

}
