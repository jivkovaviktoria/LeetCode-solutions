using System;

namespace FindTheValueOfThePartition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 2, 4};
            Console.WriteLine(FindValueOfPartition(nums)); //Expected: 1
        }
        
        public static int FindValueOfPartition(int[] nums) {
            Array.Sort(nums);
        
            var min = int.MaxValue;
            for(int i = 1; i < nums.Length; i++){
                min = Math.Min(Math.Abs(nums[i] - nums[i-1]), min);
            }
        
            return min;
        }
    }
}