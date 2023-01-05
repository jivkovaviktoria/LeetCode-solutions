using System;

namespace CountEqualAndDivisiblePairsInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 1, 2, 2, 2, 1, 3 };
            int k = 2;

            Console.WriteLine(CountPairs(nums, k)); //Expected: 4
        }
        
        public static int CountPairs(int[] nums, int k) {
            int ans = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i+1; j < nums.Length; j++)
                    if(nums[i] == nums[j] && (i*j)%k == 0) ans++;
            }
        
            return ans;
        }
    }
}