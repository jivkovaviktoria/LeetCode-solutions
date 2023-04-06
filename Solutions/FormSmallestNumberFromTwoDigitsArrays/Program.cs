using System;
using System.Collections.Generic;

namespace FormSmallestNumberFromTwoDigitsArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 4, 1, 3 }, nums2 = new int[] { 5, 7 };
            Console.WriteLine(MinNumber(nums1, nums2)); //Expected: 15
        }
        
        public static int MinNumber(int[] nums1, int[] nums2) {
            HashSet<int> hs = new HashSet<int>(nums1);
        
            Array.Sort(nums1);
            Array.Sort(nums2);
        
            for(int i = 0; i < nums2.Length; i++){
                if(hs.Contains(nums2[i])) return nums2[i];
            }
        
            return Math.Min(nums1[0]*10 + nums2[0], nums2[0]*10 + nums1[0]);
        }
    }
}