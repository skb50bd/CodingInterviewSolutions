using Library;
using Xunit;

namespace Tests {
    public class MergeOverlappingIntervalsTests {
        [Fact]
        public void MergeTest() {
            // Arrange
            var input = new[] {
                (1, 3),
                (2, 6),
                (8, 10),
                (15, 18)
            };

            var expected = new[] {
                (1, 6),
                (8, 10),
                (15, 18)
            };

            // Act
            var actual = input.MergeOverlaps();

            // Assert 
            Assert.Equal(expected, actual);
        }
    }
}