using System;
using System.Collections.Generic;
using System.Globalization;

namespace TwoSum
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 2, 7, 11, 15 };
            var target = 9;

            //Expected - [1, 0], because nums[0] + nums[1] == 9
            Console.WriteLine(string.Join(", ", TwoSum(numbers, target)));
        }

        //Complexity - O(n)
        
        //Explanation - We use dictionary to store numbers and their indexes
        //If we have two numbers whose sum is equal to {target}, then they are the keys of the dictionary
        //If one key is num, then other key is {target} - num
        private static int[] TwoSum(int[] nums, int target) {
        
            if(nums == null || nums.Length < 2) return new int[2];
        
            Dictionary<int,int> numsDic = new Dictionary<int,int>();
            for(int i = 0; i < nums.Length; i++)
            {
                if(numsDic.ContainsKey(target - nums[i])) return new int[]{i, numsDic[target - nums[i]]};
                else if(!numsDic.ContainsKey(nums[i])) numsDic.Add(nums[i], i);
            }
        
            return new int[2];
        }
    }
}