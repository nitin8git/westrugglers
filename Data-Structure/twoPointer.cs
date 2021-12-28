using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LeetCodeProblems
{
    public class Twopointer
    {
        public int MinimumIndex(int[] arr, int n)
        {
            int windowSum = 0; int maxSum = 0;
            int start = 0; int end = 0;
            while (end < n)
            {
                windowSum += arr[end++];
            }

            while (end < arr.Length)
            {
                windowSum += arr[end++] - arr[start++];
                maxSum = Math.Max(maxSum, windowSum);
            }

            return maxSum;
        }
    }
}
