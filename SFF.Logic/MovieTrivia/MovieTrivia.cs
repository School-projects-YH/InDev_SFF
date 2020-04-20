using System;
using System.Collections.Generic;
using System.Text;
using SFF.Core.MovieStudios;
using SFF.Core;


namespace SFF.Core.MovieTriviaNS
{
    public class MovieTrivia
    {
        public MovieStudio MovieStudio { get; set; }
        public Movie Movie { get; set; }
        public string ReviewSummary { get; set; }
        public int ReviewScore { get; set; }

        private MovieTrivia(MovieStudio movieStudio, Movie movie)
        {
            this.MovieStudio = movieStudio;
            this.Movie = movie;
        }
        public MovieTrivia(MovieStudio movieStudio, Movie movie, string ReviewSummary) : this(movieStudio, movie)
        {
            this.ReviewSummary = ReviewSummary;
        }
        public MovieTrivia(MovieStudio movieStudio, Movie movie, int ReviewScore) : this(movieStudio, movie)
        {
            this.ReviewScore = ReviewScore;
        }
        public MovieTrivia(MovieStudio movieStudio, Movie movie, int ReviewScore, string ReviewSummary) : this (movieStudio, movie)
        {
            this.ReviewScore = ReviewScore;
            this.ReviewSummary = ReviewSummary;
        }
    }
}
