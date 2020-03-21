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
                new[] { 13, 14, 15, 16 } };

            var expected = new[] {
                01, 02, 03, 04, 
                08, 12, 16, 15, 
                14, 13, 09, 05, 
                06, 07, 11, 10 };

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
                new [] { 7, 8, 9 } };

            var expected = new[] { 
                1, 2, 3, 
                6, 9, 8, 
                7, 4, 5 };

            // Act
            var actual = input.TraverseSpiral();
            
            // Assert
            Assert.Equal(expected, actual);
        }
    
        [Fact]
        public void SingleElement() {
            // Arrange
            var input = new int[][] { new [] { 1 } };

            var expected = new[] { 1 };

            // Act
            var actual = input.TraverseSpiral();
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void VerticalMatrix() {
            // Arrange
            var input = new int[][] { 
                new [] { 1, 2 }, 
                new [] { 3, 4 }, 
                new [] { 5, 6 }, 
                new [] { 7, 8 } };

            var expected = new[] { 1, 2, 4, 6, 8, 7, 5, 3 };

            // Act
            var actual = input.TraverseSpiral();
            
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}