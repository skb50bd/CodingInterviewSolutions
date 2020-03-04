using Library;
using Xunit;

namespace Tests {
    public class ArraySearchTests {
        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 3, 2)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 5, 4)]
        public void SearchExistingItem(int[] input, int item, int expected) {
            // Act
            var actual = input.SearchIndex(item, 0, input.Length - 1);

            // Assert
            Assert.Equal(expected, actual);

        }
    }
}