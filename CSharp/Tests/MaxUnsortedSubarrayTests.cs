using Library;
using Xunit;

namespace Tests {
    public class MaxUnsortedSubarrayTests {
        [Fact]
        public void Test1() {
            // Arrange
            var input = new[] { 1, 2, 4, 5, 6, 7, 3, 5, 6 };
            var expected = (2, 8);

            // Act
            var actual = input.FindUnsortedIndices();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2() {
            // Arrange
            var input = new[] { 1, 2, 4, 3, 5, 6 };
            var expected = (2, 3);

            // Act
            var actual = input.FindUnsortedIndices();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}