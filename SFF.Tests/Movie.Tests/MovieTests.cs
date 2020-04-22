using SFF.Datasource.Model;
using Xunit;

namespace SFF.Tests.MovieTests
{
    public class MovieTests
    {
        [Fact]
        public void Create_a_movie_with_title_and_duration()
        {
            // Arrange
            var expectedTitle = "TestTitle";
            var expectedDuration = 60;

            // Act
            var movie = new Movie(expectedTitle, expectedDuration);
            // Assert
            Assert.Equal(expectedTitle, movie.Title);
            Assert.Equal(expectedDuration, movie.Duration);
        }
    }
}