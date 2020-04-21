using System;
using System.Collections.Generic;
using System.Text;

namespace SFF.Datasource.Model
{ 
    public class MovieTrivia
    {
        public MovieStudio MovieStudio { get; set; }
        public Movie Movie { get; set; }
        public string ReviewSummary { get; set; }
        public int ReviewScore { get; set; }
    }
}
