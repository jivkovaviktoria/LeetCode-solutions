using System;
using System.Threading.Channels;

namespace FindGreatestCommonDivisorOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 5, 6, 9, 10 };

            Console.WriteLine(FindGCD(nums)); //Expected: 2

            int[] nums2 = new int[] { 7, 5, 6, 8, 3 };

            Console.WriteLine(FindGCD(nums2)); //Expected: 1
        }
        
        public static int FindGCD(int[] nums) {
            int max = nums[0], min = nums[0];
            foreach(int num in nums)
            {
                min = Math.Min(min, num);
                max = Math.Max(max, num);
            }
        
            for(int i = min; i > 1; --i)
                if(min % i == 0 && max % i == 0)
                    return i;
        
            return 1;
        }
    }
}