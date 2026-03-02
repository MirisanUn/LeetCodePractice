using _1stLeetCode;

ICallSolution sol = new Solutions();

/// 3d task
int[] nums3 = [1, 1, 0, 1, 1, 1];
OutputSolution.Output(sol.FindMaxConsecutiveOnes(nums3));

/// 4th task
int[] nums4 = [1, 2, 2, 4];
OutputSolution.Output(sol.FindErrorNums(nums4));

/// 5th task
int[] nums5 = [7, 7, 7, 7];
OutputSolution.Output(sol.SmallerNumbersThanCurrent(nums5));

/// 6th task
int[] nums6 = [4, 3, 2, 7, 7, 2, 3, 1];
OutputSolution.Output(sol.FindDisappearedNumbers(nums6));

/// 7th task
int[] target = [1,3];
OutputSolution.Output(sol.BuildArray(target, 3));

Console.ReadLine();