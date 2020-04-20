using System;
using Xunit;
using SFF.Core;
using AutoFixture;

namespace SFF.Tests.MovieTests
{
    public class MovieTests
    {
        [Fact]
        public void Create_a_movie_with_title_and_duration()
        {
            // Arrange
            var expectedTitle = "TestTitle";
            var Duration = 60m;
            var expectedDuration = "1:00";

            // Act
            var movie = new Movie(expectedTitle, Duration);
            // Assert
            Assert.Equal(expectedTitle, movie.MovieProperty.Title);
            Assert.Equal(expectedDuration, movie.MovieProperty.Duration);
        }
    }
}
