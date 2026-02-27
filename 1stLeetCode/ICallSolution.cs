using System;
using System.Collections.Generic;
using System.Text;

namespace _1stLeetCode
{
    internal interface ICallSolution
    {
        int[] GetConcatenation(int[] nums);
        int[] Shuffle(int[] nums, int n);
        int FindMaxConsecutiveOnes(int[] nums);
        /// <summary>
        /// Find the number that occurs twice and the number that is missing and return them in the form of an array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        int[] FindErrorNums(int[] nums);
    }
}
