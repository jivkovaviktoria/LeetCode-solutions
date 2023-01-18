using System;
using System.Collections.Generic;

namespace KeepMultiplyingFoundValuesByTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 5, 3, 6, 1, 12 };
            int original = 3;

            Console.WriteLine(FindFinalValue(nums, original)); //Expected: 24
        }
        
        public static int FindFinalValue(int[] nums, int original) {
            HashSet<int> hs = new HashSet<int>(nums);
            while(hs.Contains(original)){
                original = original*2;
            }
        
            return original;
        }
    }
}