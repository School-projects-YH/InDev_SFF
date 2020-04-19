using System;
using System.Collections.Generic;
using Xunit;
using SFF.Logic.MovieStudios;
using AutoFixture;

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
#warning not implemented
            // Act

            // Assert
            Assert.Equal("1", "2");
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
