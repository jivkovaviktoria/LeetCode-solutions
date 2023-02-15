using System;
using System.Collections.Generic;

namespace FindAllNumbersDisappearedInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            Console.WriteLine(FindDisappearedNumbers(nums)); //Expected: [5,6]
        }
        
        public static IList<int> FindDisappearedNumbers(int[] nums) {
            var hs = new HashSet<int>(nums);
            var ans = new List<int>();
        
            for(int i = 1; i <= nums.Length; i++){
                if(hs.Contains(i) == false) ans.Add(i);
            }
        
            return ans;
        }
    }
}