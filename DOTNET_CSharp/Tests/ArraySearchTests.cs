using Library;
using Xunit;

namespace Tests {
    public class ArraySearchTests {
        [Theory]
        
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 3, 2)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 1, 0)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 5, 4)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 6, 5)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 0, -1)]
        [InlineData(new[] { 1, 2, 4, 4, 5 }, 3, 2)]
        [InlineData(new[] { 1, 2, 4, 5 }, 4, 2)]
        public void SearchTest(int[] input, int item, int expected) {
            // Act
            var actual = input.SearchIndex(item, 0, input.Length - 1);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}