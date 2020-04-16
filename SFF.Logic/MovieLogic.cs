using System;

namespace SFF.Logic
{
    public class MovieLogic
    {
        public int numberOfMaxSimultaneouslyRented = -1;
        public int numberOfCurrentlyRented
        {
            get
            {
#warning always 10
                return 10;
            }
            set
            {
                if (isMaxRented(value))
                {
                    // numberOfCurrentlyRented = value;
                }
                else
                {
                    throw new Exception("Max number of rented movies reached already");
                }
            }
        }
        private bool isMaxRented(int numberOfRentedMovies) => numberOfCurrentlyRented + numberOfRentedMovies <= numberOfMaxSimultaneouslyRented;
    }
}
