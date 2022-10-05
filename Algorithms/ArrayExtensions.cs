﻿using System;

namespace Algorithms
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Search algorithm to find an item in a sorted array called binary search
        /// </summary>
        /// <param name="input">the sorted array to be searched</param>
        /// <param name="item">the item we are searching for in the array</param>
        /// <returns></returns>
        public static int FindIdByBinarySearch(this int[] input, int item)
        {
            return BinarySearchRec(input, 0, input.Length - 1, item);
        }
        internal static int BinarySearchRec(int[] input, int l, int r, int item)
        {
            if (r - l >= 0)
            {
                int mid = l + (r - l) / 2;

                if (input[mid] == item)
                    return mid;

                if (input[mid] > item)
                    return BinarySearchRec(input, l, mid - 1, item);

                return BinarySearchRec(input, mid + 1, r, item);
            }

            return -1;
        }
    }
}
