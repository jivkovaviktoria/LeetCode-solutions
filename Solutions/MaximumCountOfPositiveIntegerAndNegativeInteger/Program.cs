using System;
using System.Linq;

namespace MaximumCountOfPositiveIntegerAndNegativeInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] { -2, -1, -3, 0, 0, 1, 2 };
            Console.WriteLine(MaximumCount(nums)); //Expected: 3
        }
        
        public static int MaximumCount(int[] nums)
        {
            return Math.Max(nums.Count(x => x < 0), nums.Count(x => x > 0));
        }
    }
}