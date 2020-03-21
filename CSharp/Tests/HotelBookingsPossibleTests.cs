using Xunit;
using Checker = Library.HotelBookingsPossible;

namespace Tests {
    public class HotelBookingsPossibleTests {
        [Fact]
        public void Test() {
            // Arrange
            var arrivals = new[] { 1, 3, 5 };
            var departures = new[] { 2, 6, 8 };

            // Act
            var trueActual = Checker.Check(arrivals, departures, 2);
            var falseActual = Checker.Check(arrivals, departures, 1);

            // Assert
            Assert.True(trueActual);
            Assert.False(falseActual);
        }
    }
}