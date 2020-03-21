using Library;
using Xunit;

namespace Tests {
    public class MaxIndexDistanceTest {
        [Fact]
        public void Test() {
            // Arrange
            var input = new int[] { 3, 5, 4, 2 };
            var expected = 2;

            // Act
            var actual = input.CalculateMaxIndexDistance();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}