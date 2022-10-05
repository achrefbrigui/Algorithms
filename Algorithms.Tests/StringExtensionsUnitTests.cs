using Xunit;

namespace Algorithms.Tests
{
    public class StringExtensionsUnitTests
    {
        [Theory]
        [InlineData("elle", true)]
        [InlineData("ll", true)]
        [InlineData("a", true)]
        [InlineData("palyndrome", false)]
        public void IsPalyndromeUnitTest(string input, bool expected)
        {
            Assert.Equal(expected, input.IsPalyndrome());
        }
    }
}
