using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using AutoFixture;
using SFF.Models;

namespace SFF.Tests
{
    public class RentLogicTests
    {

        [Fact]
        public void Does_a_max_rented_capicity_exist()
        {
            // Arrange
            var fixture = new Fixture();
            var title = fixture.Create<string>();
            var duration = fixture.Create<decimal>();

            var movie = new Movie(title, duration);

            // Act

            // Assert
            Assert.True(movie.numberOfMaxSimultaneouslyRented > 0);
        }
        [Fact]
        public void Can_you_change_the_number_of_times_a_movie_can_be_rented()
        {
            // Arrange
            var fixture = new Fixture();
            var title = fixture.Create<string>();
            var duration = fixture.Create<decimal>();
            var movie = new Movie(title, duration);

            var exectedNumberOfTimesYouCanRent = 10;

            // Act
            movie.numberOfMaxSimultaneouslyRented = exectedNumberOfTimesYouCanRent;

            // Assert
            Assert.Equal(movie.numberOfMaxSimultaneouslyRented, exectedNumberOfTimesYouCanRent);
        }
        [Fact]
        public void Is_it_possible_to_rent_more_than_allowed()
        {
            // Arrange
            var fixture = new Fixture();
            var title = fixture.Create<string>();
            var duration = fixture.Create<decimal>();
            var movie = new Movie(title, duration);

            var numberOfTimesYouCanRent = 10;
            
            // Act
            movie.numberOfMaxSimultaneouslyRented = numberOfTimesYouCanRent;

            // Assert
            // Test if you can rent a movie over the set limit
            Assert.Throws<Exception>(() => movie.RentMovie(numberOfTimesYouCanRent + 1));

        }
        [Fact]
        public void Is_it_possible_to_mark_a_movie_as_rented()
        {
            // Arrange

            // Act

            // Assert
        }

    }
}
