using System;
using System.Collections.Generic;
using Xunit;
using SFF.Core.MovieStudios;
using AutoFixture;
using SFF.Datasource.Context;
using Moq;
using SFF.Datasource.Repository;


namespace SFF.Tests.MovieStudioTests
{
    public class MovieStudioTests
    {
        [Fact]
        public void Create_a_Movie_Studio_with_name_and_city()
        {
            // Arrange
            Fixture fixture = new Fixture();
            var expectedName = fixture.Create<string>();
            var expectedCity = fixture.Create<string>();

            // Act
            MovieStudio movieStudio = new MovieStudio(expectedName, expectedCity);

            // Assert
            Assert.Equal(expectedName, movieStudio.Name);
            Assert.Equal(expectedCity, movieStudio.City);

        }
        [Fact]
        public void Create_a_Movie_Studio_with_name_city_and_adress()
        {
            Create_a_Movie_Studio_with_name_and_city();
            // Arrange
            Fixture fixture = new Fixture();
            var expectedName = fixture.Create<string>();
            var expectedCity = fixture.Create<string>();
            var expectedAdress = fixture.Create<string>();

            // Act
            MovieStudio movieStudio = new MovieStudio(expectedName, expectedCity, expectedAdress);

            // Assert
            Assert.Equal(expectedAdress, movieStudio.Adress);
        }

        [Fact]
        public void Remove_a_movie_studio()
        {
            // Arrange
            var fixture = new Fixture();
            
            var mockMovieStudioRepository = new Mock<IRepository<MovieStudio>>();
            var expectedMovieStudio = fixture.Create<MovieStudio>();
            // Act
            mockMovieStudioRepository.Object.Delete(expectedMovieStudio);

            // Assert
            mockMovieStudioRepository.Verify((m => m.Delete(expectedMovieStudio)), Times.Once);
        }

        [Fact]
        public void Change_name_and_city_on_a_movie_studio()
        {
            // Arrange
            Fixture fixture = new Fixture();
            var oldName = fixture.Create<string>();
            var oldCity = fixture.Create<string>();

            var expectedName = fixture.Create<string>();
            var expectedCity = fixture.Create<string>();

            MovieStudio movieStudio = new MovieStudio(oldName, oldCity)
            {

                // Act
                Name = expectedName,
                City = expectedCity
            };

            // Assert
            Assert.Equal(expectedName, movieStudio.Name);
            Assert.Equal(expectedCity, movieStudio.City);
        }
    }
}
