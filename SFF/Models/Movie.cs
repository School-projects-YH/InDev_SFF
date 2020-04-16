using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SFF.Models
{
    public class Movie
    {
        public Movie(string Title, decimal Duration)
        {

        }


        [Key]
        public long Id { get; set; }
        public string Title { get; set; }
        public string Duration
        {
            get { return DurationFormat(); }
            set
            {
                DurationInMinutes = Int32.Parse(value);
            }
        }
        private int DurationInMinutes { get; set; }

        private string DurationFormat()

        {
            float dim = DurationInMinutes;
            double hours = Math.Truncate(dim / 60f);
            double minutes = dim - (hours * 60);

            string returnString = hours.ToString() + ':' + minutes.ToString();

            return returnString;
        }
    }

}
