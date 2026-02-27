using _1stLeetCode;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Solutions : ICallSolution {
    public int[] GetConcatenation(int[] nums) { /// 1st task
        int n = 0;
        foreach (var item in nums)
        {
            n++;
        }
        int[] result = new int[2*n];
        int newLength = 2*n;
        for (int i = 0; i < newLength; i++)
        {
            if (i >= n)
            {
                result[i] = nums[i - n];
            }
            else
            {
                result[i] = nums[i];
            }
        }
        return result;
    }
    /// <summary>
    /// Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
    /// Return the array in the form[x1, y1, x2, y2, ..., xn, yn].
    /// </summary>
    /// <param name="nums"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public int[] Shuffle(int[] nums, int n) /// 2nd task
    {
        int newLength = 2 * n;
        int[] result = new int[newLength];
        for (int i = 0; i < newLength; i++)
        {
            if (i < n)
            {
                result[i + i] = nums[i];
            }
            else
            {
                result[i - ((newLength - 1) - i)] = nums[i];
            }
        }
        return result;
    }
    /// <summary>
    /// Given a binary array nums, return the maximum number of consecutive 1's in the array.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int FindMaxConsecutiveOnes(int[] nums) /// 3d task
    {
        int result = 0;
        int maxOnesCons = 0;
        foreach (var item in nums)
        {
            if (item == 1)
            {
                maxOnesCons++;
            }
            else
            {
                result = result > maxOnesCons ? result : maxOnesCons;
                maxOnesCons = 0;
            }
        }
        return result > maxOnesCons ? result : maxOnesCons;
    }
    /// <summary>
    /// You have a set of integers s, which originally contains all the numbers from 1 to n.
    /// Unfortunately, due to some error, one of the numbers in s got duplicated to another number in the set, which results in repetition of one number and loss of another number.
    ///You are given an integer array nums representing the data status of this set after the error.
    ///Find the number that occurs twice and the number that is missing and return them in the form of an array.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] FindErrorNums(int[] nums)
    {
        int[] result = new int[2];
        int arr_sum_expect = (nums.Length * (nums.Length + 1)) / 2;
        HashSet<int> seen = new HashSet<int>();
        foreach (int num in nums)
        {
            if (!seen.Add(num))
                result[0] = num;
        }
        result[1] = result[0] + (arr_sum_expect - nums.Sum());
        return result;
    }
}