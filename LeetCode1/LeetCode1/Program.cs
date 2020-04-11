using System;

namespace LeetCode1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 4 };
            int target = 6;
            var result = TwoSum(nums, target);
            Console.WriteLine("Index of numbers that make up {0} are: {1} and {2} ", target, result[0], result[1]);
            Console.ReadLine();
        }

        /// <summary>
        /// O(n^2) Solution, most simple
        /// </summary>
        /// <param name="nums">The numbers</param>
        /// <param name="target">The target</param>
        /// <returns></returns>
        public static int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                var t1 = nums[i];
                for (int x = 0; x < nums.Length; x++)
                {
                    if (x == i) continue;
                    if (nums[x] + t1 == target)
                    {
                        result[0] = i;
                        result[1] = x;
                        return result;
                    }
                }
            }
            throw new Exception("No number match up to target");
        }

        /// <summary>
        /// O(n) Solution based on hashmaps
        /// </summary>
        /// <param name="nums">The numbers</param>
        /// <param name="target">The target</param>
        /// <returns></returns>
        public static int[] TwoSumHashMap(int[] nums, int target)
        {
            var result = new int[2];
            throw new NotImplementedException();
        }
    }
}
