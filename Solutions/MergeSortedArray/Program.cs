using System;

namespace MergeSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var nums2 = new int[] { 2, 5, 6 };
            int m = nums1.Length, n = nums2.Length;
            
            Merge(nums1, m, nums2, n);
            
            //Expected: nums1 = [1,2,2,3,5,6]
            Console.WriteLine(String.Join(",", nums1));
        }

        private static void Merge(int[] nums1, int m, int[] nums2, int n) {
            for(var i = 0; i < nums2.Length; i++)
                nums1[nums1.Length-1-i] = nums2[i]; //We append the elements of `nums2` to the end of `nums1`
      
            Array.Sort(nums1);
        }
    }
}