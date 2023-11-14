namespace Algorithms.Tests.NonLinearDataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Algorithms.LinearDataStructure.Extensions;
    using Algorithms.NonLinearDataStructure.Extensions;
    using Algorithms.NonLinearDataStructure.Models;
    using Xunit;

    public class BinaryTreeUnitTests
    {
          public static IEnumerable<object[]> CustomInlineDate => 
            new List<object[]>
            {
                new object[] { new int[] { 1, 2, 3 }, "1 2 3" },
                new object[] { new int[] { 1, 5, 3, 7, 9, 8 }, "1 5 7 9 3 8" }
            };

        [Theory, MemberData(nameof(CustomInlineDate))]
        public void IsPreOderUnitTest(int[] input, string expected)
        {
            var bt = new BinaryTree<int>(input);

            Assert.Equal(expected, bt.PreOrderTraversal());
        }
    }
}
