using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class StringExtensions
    {
        public static bool IsPalyndrome(this string input)
        {
            if (input.Length == 1 || input.Length == 0) return true;
            if (input.Length == 2) return input[0] == input[1];
            if (input[0] == input[input.Length - 1]) return IsPalyndrome(input.Substring(1, input.Length - 2));
            return false;
        }
    }
}
