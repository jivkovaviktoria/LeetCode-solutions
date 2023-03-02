using System;

namespace FindTheMiddleIndexInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 3, -1, 8, 4 };
            Console.WriteLine(FindMiddleIndex(nums)); //Expected: 3
        }
        
        public static int FindMiddleIndex(int[] nums) {
            int sum = 0;
            foreach(var num in nums) sum += num;
        
            int leftSum = 0;
            for(int i = 0; i < nums.Length; i++)
            {           
                if(sum - nums[i] - leftSum == leftSum) return i;
                leftSum += nums[i];
            }
        
            return -1;
        }
    }
}