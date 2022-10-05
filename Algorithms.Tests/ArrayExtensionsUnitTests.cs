using Xunit;

namespace Algorithms.Tests
{
    public class ArrayExtensionsUnitTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 5, 6 }, 1, 0)]
        [InlineData(new int[] { 1, 2, 3, 5, 6, 7 }, 6, 4)]
        [InlineData(new int[] { 1, 2, 3, 5, 6, 7 }, 7, 5)]
        [InlineData(new int[] { 1, 2, 3, 5, 6, 7 }, 9, -1)]
        [InlineData(new int[] { 1, 2, 3, 5, 6, 7, 8 }, 9, -1)]
        public void BinarySearchArrayUnitTest(int[] input, int item, int expectedId)
        {
            Assert.Equal(expectedId, input.FindIdByBinarySearch(item));
        }
    }
}
