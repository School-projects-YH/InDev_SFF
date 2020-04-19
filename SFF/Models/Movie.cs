//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using System.ComponentModel.DataAnnotations;
//using SFF.Logic;

//namespace SFF.Models
//{
//    public class Movie : MovieProperty
//    {
//        public bool isRented;
//        public Movie(string Title, decimal Duration)
//        {
//            this.Title = Title;
//            DurationInMinutes = Decimal.ToInt32(Duration);
//            // Standard value 10
//            numberOfMaxSimultaneouslyRented = 10;
//        }
//        public Movie(string Title, decimal Duration, int MaxSimultaneouslyRented) : this (Title, Duration)
//        {
//            numberOfMaxSimultaneouslyRented = MaxSimultaneouslyRented;
//        }


//        [Key]
//        public long Id { get; set; }
//        public string Title { get; set; }
//        public string Duration
//        {
//            get { return DurationFormat(); }
//            set
//            {
//                DurationInMinutes = Int32.Parse(value);
//            }
//        }
//        private int DurationInMinutes { get; set; }

//        private string DurationFormat()
//        {
//            string Format = ":0#";
//            float dim = DurationInMinutes;
//            double hours = Math.Truncate(dim / 60f);
//            double minutes = dim - (hours * 60);


//            string returnString = hours.ToString() + minutes.ToString(Format);

//            return returnString;
//        }
//    }

//}
