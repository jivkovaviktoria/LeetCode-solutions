using System;
using System.Collections.Generic;

namespace ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 2, 3, 1 };

            Console.WriteLine(ContainsDuplicate(nums));
            //Expected: true
        }
        
        //We use hashset on nums, because if there is a duplicate
        //we will add the number only once(hashset doesn't allow
        //duplicates), so if there are duplicates the count of the
        //hashset 'hs' will be smaller than the nums count
        public static bool ContainsDuplicate(int[] nums) {
        
            HashSet<int> hs = new HashSet<int>(nums);
            if(nums.Length == hs.Count) return false;
        
            return true;
        }
    }
}