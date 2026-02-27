using System;
using System.Collections.Generic;
using System.Text;

namespace _1stLeetCode
{
    internal static class OutputSolution
    {
        internal static void Output(int result)
        { 
            Console.WriteLine($"{result}");
        }
        internal static void Output(int[] result)
        {
            string output = $"[{string.Join(",", result)}]";
            Console.WriteLine(output);
        }
    }
}
