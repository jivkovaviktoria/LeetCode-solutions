using System;

namespace MinimumNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 4, 2, 3 };
            Console.WriteLine(string.Join(", ", NumberGame(nums))); //Expected: [3, 2, 5, 4]
        }
        
        public static int[] NumberGame(int[] nums) {
            int[] res = new int[nums.Length];
        
            Array.Sort(nums);
            for(int i = 0; i < nums.Length-1; i+=2){
                res[i] = nums[i+1];
                res[i+1] = nums[i];
            }
        
            return res;
        }
    }
}