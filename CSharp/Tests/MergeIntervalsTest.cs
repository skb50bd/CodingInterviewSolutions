using Library;
using Xunit;

namespace Tests
{
    public class MergeIntervalsTest
    {
        [Fact]
        public void BeginningOfTheIntervals()
        {
            // Arrange
            var input = new[] {
                (5, 8),
                (9, 11)
            };

            var expected = new[] {
                (1, 3),
                (5, 8),
                (9, 11)
            };

            // Act
            var actual = input.InsertAndMerge((1, 3));

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertAndMergeIntoAnEmptyIntervalList()
        {
            // Arrange
            var input = new(int, int)[] { };

            var expected = new[] {
                (1, 3)
            };

            // Act
            var actual = input.InsertAndMerge((1, 3));

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EndOfTheIntervals()
        {
            // Arrange
            var input = new[] {
                (5, 8),
                (9, 11)
             };

            var expected = new[] {
                (5, 8),
                (9, 11),
                (12, 13)
            };

            // Act
            var actual = input.InsertAndMerge((12, 13));

            // Assert
            Assert.Equal(expected, actual);
        }
    
        [Fact]
        public void InBetweenTwoIntervals()
        {
            // Arrange
            var input = new[] {
                (1, 5),
                (9, 11)
             };

            var expected = new[] {
                (1, 5),
                (6, 7),
                (9, 11)
            };

            // Act
            var actual = input.InsertAndMerge((6, 7));

            // Assert
            Assert.Equal(expected, actual);
        }
    
        [Fact]
        public void InsideAnInterval()
        {
            // Arrange
            var input = new[] {
                (5, 8),
                (9, 11)
             };

            var expected = new[] {
                (5, 8),
                (9, 11)
            };

            // Act
            var actual = input.InsertAndMerge((6, 8));

            // Assert
            Assert.Equal(expected, actual);
        }
    
        [Fact]
        public void AllIntervalsFitInsideTheNewInterval()
        {
            // Arrange
            var input = new[] {
                (5, 8),
                (9, 11)
             };

            var expected = new[] {
                (1, 13)
            };

            // Act
            var actual = input.InsertAndMerge((1, 13));

            // Assert
            Assert.Equal(expected, actual);
        }
    
        [Fact]
        public void OverlapsWithOne_1()
        {
            // Arrange
            var input = new[] {
                (5, 8),
                (9, 11)
             };

            var expected = new[] {
                (1, 8),
                (9, 11)
            };

            // Act
            var actual = input.InsertAndMerge((1, 6));

            // Assert
            Assert.Equal(expected, actual);
        }
    
        [Fact]
        public void OverlapsWithOne_2()
        {
            // Arrange
            var input = new[] {
                (3, 5),
                (9, 11)
             };

            var expected = new[] {
                (3, 5),
                (7, 11)
            };

            // Act
            var actual = input.InsertAndMerge((7, 10));

            // Assert
            Assert.Equal(expected, actual);
        }
    
        [Fact]
        public void OverlapsWithTwo()
        {
            // Arrange
            var input = new[] {
                (5, 8),
                (9, 11)
             };

            var expected = new[] {
                (5, 11)
            };

            // Act
            var actual = input.InsertAndMerge((7, 10));

            // Assert
            Assert.Equal(expected, actual);
        }
    
        [Fact]
        public void OverlapsWithMultipleIntervals()
        {
            // Arrange
            var input = new[] {
                (1, 4),
                (5, 8),
                (9, 11),
                (13, 15)
             };

            var expected = new[] {
                (1, 12),
                (13, 15)
            };

            // Act
            var actual = input.InsertAndMerge((2, 12));

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
