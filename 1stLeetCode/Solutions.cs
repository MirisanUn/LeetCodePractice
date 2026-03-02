using _1stLeetCode;
using System.Collections;
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
    /// <summary>
    /// Given the array nums, for each nums[i] find out how many numbers in the array are smaller than it.
    /// That is, for each nums[i] you have to count the number of valid j's such that j != i and nums[j] < nums[i].
    /// Return the answer in an array.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int[] result = new int[nums.Length]; 
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i != j && nums[i] > nums[j])
                {
                    result[i] += 1;
                }
            }
        }
        return result;
    }
    /// <summary>
    /// Given an array nums of n integers where nums[i] is in the range [1, n], 
    /// return an array of all the integers in the range [1, n] that do not appear in nums.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        IList<int> result = new List<int>();
        HashSet<int> sequence = new HashSet<int>();
        foreach (int num in nums)
        {
            sequence.Add(num);
        }
        for (int i = 1; i <= nums.Length; i++)
        {
            if (sequence.Add(i))
            {
                result.Add(i);
            }
        }
        return result;
    }
    /// <summary>
    /// You are given an integer array target and an integer n.
    /// You have an empty stack with the two following operations:
    /// "Push": pushes an integer to the top of the stack.
    /// "Pop": removes the integer on the top of the stack.
    /// Ex.1
    /// Input: target = [1,3], n = 3
    /// Output: ["Push", "Push", "Pop", "Push"]
    /// Ex.2
    /// Input: target = [1,2,3], n = 3
    /// Output: ["Push","Push","Push"]
    /// </summary>
    /// <param name="target"></param>
    /// <param name="n"></param>
    /// <returns></returns>
    public IList<string> BuildArray(int[] target, int n)
    {
        var set = new HashSet<int>(target);
        int max = target.Max();
        IList<string> result = new List<string>(max * 2);

        for (int i = 1; i <= max; i++)
        {
            if (set.Contains(i))
            {
                result.Add("Push");
            }
            else
            {
                result.Add("Push");
                result.Add("Pop");
            }
        }
        return result;
    }
}