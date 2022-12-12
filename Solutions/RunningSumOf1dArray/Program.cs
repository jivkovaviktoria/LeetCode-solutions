using System;

namespace RunningSumOf1dArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(string.Join(",", RunningSum(nums)));  //Expected: [1,3,6,10]
        }

        //We make a new array res and at each index of it (res[i]) we set
        //the sum of the current number (nums[i]) and the sum of the previous ones (res[i-1])
        private static int[] RunningSum(int[] nums) {
            
            int[] res = new int[nums.Length];
            
            res[0] = nums[0];
            for(int i = 1; i < nums.Length; i++)
                res[i] = nums[i] + res[i-1];
            
            return res;
        }
    }
}