using System;

namespace SFF.Logic
{
    public class MovieLogic
    {
        public int numberOfMaxSimultaneouslyRented = -1;
        public void RentMovie(int numberOfMovies)
        {
            if (isMaxRented(numberOfMovies))
            {
                numberOfCurrentlyRented = numberOfMovies;
            }
            else
            {
                throw new Exception("Max number of rented movies reached already");
            }
        }
        private int numberOfCurrentlyRented { get; set; }
        private bool isMaxRented(int numberOfRentedMovies) => numberOfCurrentlyRented + numberOfRentedMovies <= numberOfMaxSimultaneouslyRented;
    }
}
