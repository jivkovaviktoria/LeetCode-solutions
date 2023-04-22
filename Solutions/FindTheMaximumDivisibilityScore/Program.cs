using System;
using System.Collections.Generic;
using System.Linq;

namespace FindTheMaximumDivisibilityScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 7, 9, 3, 9 }, divisors = new int[] { 5, 2, 3 };
            Console.WriteLine(MaxDivScore(nums, divisors)); //Expected: 3
        }
        
        public static int MaxDivScore(int[] nums, int[] divisors) {
            Dictionary<int, int> d = new Dictionary<int, int>();
        
            foreach(int div in divisors) d[div] = nums.Count(n => n % div == 0);
        
            int max = d.Values.Max();
            int result = d.Where(x => x.Value == max).Min(x => x.Key);
        
            return result;
        }
    }
}