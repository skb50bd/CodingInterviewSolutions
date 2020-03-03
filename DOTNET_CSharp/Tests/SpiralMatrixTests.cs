using Library;
using Xunit;

namespace Tests {
    public class SpiralMatrixTests {
        [Fact]
        public void EvenMatrix() {
            // Arrange
            var input = new int[][] {
                new[] { 01, 02, 03, 04 },
                new[] { 05, 06, 07, 08 },
                new[] { 09, 10, 11, 12 },
                new[] { 13, 14, 15, 16 } 
            };
            var expected = new[] {
                1, 2, 3, 4, 8, 12, 16, 15, 14, 13, 9, 5, 6, 7, 11, 10
            };

            // Act
            var actual = input.TraverseSpiral();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OddMatrix() {
            // Arrange
            var input = new int[][] {
                new [] { 1, 2, 3 },
                new [] { 4, 5, 6 },
                new [] { 7, 8, 9 }
            };
            var expected = new[] {
                1, 2, 3, 6, 9, 8, 7, 4, 5
            };

            // Act
            var actual = input.TraverseSpiral();
            
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}