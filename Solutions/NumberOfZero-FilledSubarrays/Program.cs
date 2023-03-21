using System;
using System.Threading.Channels;

namespace NumberOfZero_FilledSubarrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 0, 0, 2, 0, 0, 4 };
            Console.WriteLine(ZeroFilledSubarray(nums)); //Expected: 6
        }
        
        public static long ZeroFilledSubarray(int[] nums) {
            long ans = 0;
            int count = 0;
        
            for(int i = 0; i < nums.Length; i++){
                if(nums[i] == 0) count++;
                else count = 0;
                ans += count;
            }
        
            return ans;
        }
    }
}