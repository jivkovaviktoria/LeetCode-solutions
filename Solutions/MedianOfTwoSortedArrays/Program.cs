using System;

namespace MedianOfTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2 };
            int[] nums2 = new int[] { 3, 4 };

            Console.WriteLine(FindMedianSortedArrays(nums1, nums2)); //Expected: 2.5
        }

        //This method takes in two sorted arrays, nums1 and nums2, and finds the median value of the combined sorted array.
        //It does this by first creating a new array called merged that is the concatenation of nums1 and nums2.
        //It then sorts the merged array using the Array.Sort method. Finally, it determines the median value of the
        //merged array. If the length of the merged array is odd, then the median is simply the middle element of the array.
        //If the length of the merged array is even, then the median is the average of the two middle elements of the array.
        //The median value is returned as a double.
        private static double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            int[] merged = new int[nums1.Length + nums2.Length];
        
            for(int i = 0; i < nums1.Length; i++)
                merged[i] = nums1[i];

            for (int i = nums1.Length, j = 0;i < merged.Length; i++, j++)
                merged[i] = nums2[j];
        
            double ans = 0;
            Array.Sort(merged);
            
            if(merged.Length % 2 == 1) ans = merged[merged.Length/2];
            else
            {
                double x1 = merged[merged.Length/2];
                double x2 = merged[merged.Length/2-1];
            
                ans = (x1+x2)/2;
            }
        
            return ans;
        }
    }
}