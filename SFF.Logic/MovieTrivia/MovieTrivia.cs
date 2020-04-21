using System;
using System.Collections.Generic;
using System.Text;
using SFF.Datasource.Model;


namespace SFF.Core.MovieTriviaNS
{
    public class MovieTrivia : SFF.Datasource.Model.MovieTrivia
    {
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
