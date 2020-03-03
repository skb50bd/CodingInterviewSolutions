using Library;
using Xunit;

namespace Tests {
    public class MaxSumSubarrayTests {
        [Fact]
        public void Test1() {
            // Arrange
            var input = new [] { 3, -4, 5, 1, 10, -12, -5, 8, 9 };
            var expected = (17, new[] { 8, 9 });

            // Act
            var actual = input.CalculateMaxSubarray();

            // Assert
            Assert.Equal(expected.Item1, actual.Item1);
            Assert.Equal(expected.Item2, actual.Item2);
        }

        [Fact]
        public void Test2() {
            // Arrange
            var input = new [] { -1, -2, 1, 2, 3, -5, -4 };
            var expected = (6, new[] { 1, 2, 3 });

            // Act
            var actual = input.CalculateMaxSubarray();

            // Assert
            Assert.Equal(expected.Item1, actual.Item1);
            Assert.Equal(expected.Item2, actual.Item2);
        }
    }
}