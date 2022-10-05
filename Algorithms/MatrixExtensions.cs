using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{        

    public static class MatrixExtensions
    {    
        //public enum ERotationType { ClockWise, AClockWise };

        public static int[,] NinetyDegRotation(this int[,] input, bool isClockwise)
        {
            return isClockwise ? input.ClockWise() : input.AClockWise();
        }

        public static int[,] ClockWise(this int[,] input)
        {
            var output = new int[input.GetLength(1), input.GetLength(0)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    output[j, input.GetLength(0) - 1 - i] = input[i, j];
                }
            }
           
            return output;
        }

        public static int[,] AClockWise(this int[,] input)
        {
            var output = new int[input.GetLength(1), input.GetLength(0)];

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = input.GetLength(1) - 1; j >= 0; j--)
                {
                    output[input.GetLength(1) - 1 - j, i] = input[i, j];
                }
            }
     
            return output;
        }
        
    }
}