using Library;
using Xunit;

namespace Tests {
    public class GridPathTests {
        [Fact]
        public void TestConst() {
            // Arrange
            var expected = 10;

            // Act
            var actual = GridExtensions.CountUniquePathsConst(3, 4);
            
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDP() {
            // Arrange
            var expected = 10;

            // Act
            var actual = GridExtensions.CountUniquePathsDP(3, 4);
            
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}