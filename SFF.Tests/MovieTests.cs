using System;
using Xunit;
using SFF.Models;
using AutoFixture;
using SFF.Controllers;

namespace SFF.Tests
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
            Assert.Equal(expectedTitle, movie.Title);
            Assert.Equal(expectedDuration, movie.Duration);
        }
    }
}
