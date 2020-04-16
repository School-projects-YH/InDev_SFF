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
        public void Create_a_movie()
        {
            // Arrange
            var fixture = new Fixture();
            var movieContext = fixture.Create<MovieContext>();

            var sut = new MovieController(movieContext);

            // Act
            sut.PostMovie()
            
            // Assert
        }
    }
}
