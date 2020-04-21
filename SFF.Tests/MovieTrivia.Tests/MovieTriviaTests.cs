﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using AutoFixture;
using SFF.Core.MovieTriviaNS;
using SFF.Core.MovieStudios;
using SFF.Core;
using SFF.Datasource.Model;

namespace SFF.Tests.MovieTriviaTests
{
    public class MovieTriviaTests
    {
        [Fact]
        public void Create_a_movie_review_with_text()
        {
            // Arrange
            var fixture = new Fixture();
            var expectedSummary = fixture.Create<string>();
            var expectedMovieStudio = fixture.Create<SFF.Core.MovieStudios.MovieStudio>();
            var expectedMovie = fixture.Build<SFF.Core.Movie>()
                .With(x => x.MovieProperty, fixture.Build<MovieProperty>()
                    .With(x => x.Duration, "100")
                    .Create())
                .Create();


            // Act
            SFF.Core.MovieTriviaNS.MovieTrivia movieTrivia = new SFF.Core.MovieTriviaNS.MovieTrivia(expectedMovieStudio, expectedMovie, expectedSummary);

            // Assert
            Assert.Equal(expectedMovieStudio, movieTrivia.MovieStudio);
            Assert.Equal(expectedSummary, movieTrivia.ReviewSummary);
        }
        [Fact]
        public void Create_a_movie_review_with_score()
        {
            // Arrange
            var fixture = new Fixture();
            var expectedScore = fixture.Create<int>();
            var expectedMovieStudio = fixture.Create<SFF.Core.MovieStudios.MovieStudio>();
            var expectedMovie = fixture.Build<SFF.Core.Movie>()
                .With(x => x.MovieProperty, fixture.Build<MovieProperty>()
                    .With(x => x.Duration, "100")
                    .Create())
                .Create();


            // Act
            SFF.Core.MovieTriviaNS.MovieTrivia movieTrivia = new SFF.Core.MovieTriviaNS.MovieTrivia(expectedMovieStudio, expectedMovie, expectedScore);

            // Assert
            Assert.Equal(expectedMovieStudio, movieTrivia.MovieStudio);
            Assert.Equal(expectedScore, movieTrivia.ReviewScore);
        }

        [Fact]
        public void Create_a_movie_review_with_score_and_text()
        {
            // Arrange
            var fixture = new Fixture();
            var expectedScore = fixture.Create<int>();
            var expectedSummary = fixture.Create<string>();
            var expectedMovieStudio = fixture.Create<SFF.Core.MovieStudios.MovieStudio>();
            var expectedMovie = fixture.Build<SFF.Core.Movie>()
                .With(x => x.MovieProperty, fixture.Build<MovieProperty>()
                    .With(x => x.Duration, "100")
                    .Create())
                .Create();


            // Act
            SFF.Core.MovieTriviaNS.MovieTrivia movieTrivia = new SFF.Core.MovieTriviaNS.MovieTrivia(expectedMovieStudio, expectedMovie, expectedScore, expectedSummary);

            // Assert
            Assert.Equal(expectedMovieStudio, movieTrivia.MovieStudio);
            Assert.Equal(expectedScore, movieTrivia.ReviewScore);
            Assert.Equal(expectedSummary, movieTrivia.ReviewSummary);
        }
    }
}
