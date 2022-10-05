using System.Collections.Generic;
using Xunit;

namespace Algorithms.Tests
{
    public class MatrixUnitTests
    {
        [Theory]
        [MemberData(nameof(ClockWiseData))]
        public void ClockWiseDataUnitTest(int[,] expected, int[,] input)
        {
            Assert.Equal(expected, input.ClockWise());
        }

        [Theory]
        [MemberData(nameof(AClockWiseData))]
        public void AClockWiseDataUnitTest(int[,] expected, int[,] input)
        {
            Assert.Equal(expected, input.AClockWise());
        }

        public static IEnumerable<object[]> AClockWiseData =>
           new List<object[]>
           {
                new object[] { new int[,] { { 3, 6, 9 }, { 2, 5, 8 }, { 1, 4, 7 } }, new int[,] {{ 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } } },
                new object[] { new int[,] { { 3, 6 }, { 2, 5 }, { 1, 4 } }, new int[,] {{ 1, 2, 3 }, { 4, 5, 6 } } },
           };

        public static IEnumerable<object[]> ClockWiseData =>
           new List<object[]>
           {
                new object[] { new int[,] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } }, new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } } },
                new object[] { new int[,] {{ 4, 1 }, { 5, 2 }, { 6, 3 } }, new int[,] { { 1, 2, 3 }, { 4, 5, 6 } } },
           };
    }
}
