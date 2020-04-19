using System;
using System.Globalization;
using SFF.Models;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace SFF.Logic
{
    public class MovieProperty
    {
        public int NumberOfMaxSimultaneouslyRented { get; set; }
        public bool IsRented { get; set; } = false;
        public int NumberOfCurrentlyRented { get; set; }
        
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
            string Format = ":0#";
            float dim = DurationInMinutes;
            double hours = Math.Truncate(dim / 60f);
            double minutes = dim - (hours * 60);
            var cultureInfo = CultureInfo.CurrentCulture;


            string returnString = hours.ToString(cultureInfo) + minutes.ToString(Format, cultureInfo);

            return returnString;
        }
    }
}
