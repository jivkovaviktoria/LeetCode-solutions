using System;

namespace JumpGameII
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 3, 1, 1, 4 };
            Console.WriteLine(Jump(nums)); //Expected: 2
        }
        
        public static int Jump(int[] nums) {
        
            int ans = 0;
            int furthest = -1, target = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                furthest = Math.Max(nums[i] + i, furthest);
                if (i == target)
                {
                    ans++;
                    target = furthest;
                }
            }
        
            return ans; 
        }
    }
}