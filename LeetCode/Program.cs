using System;

namespace LeetCode
{
    class Program
    {
        private static int[] numberArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        private static int target = 32;
        private static string romanNumber = "MCMXCIV";

        static void Main(string[] args)
        {
            TwoSum.Program.getNumberIndexWithTwoPointer(numberArray, target);
        }
    }
}
