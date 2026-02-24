public class Solutions {
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
        int[] result = new int[2*n];
        for (int i = 0; i < newLength; i++)
        {
            if (i < n)
            {
                result[i + i] = nums[i];
            }
            else
            {
                result[i - ((n * 2 - 1) - i)] = nums[i];
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
                result = maxOnesCons;
                maxOnesCons = 0;
            }
        }
        return result;
    }
}