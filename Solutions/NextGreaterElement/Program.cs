using System;

namespace NextGreaterElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 4, 2, 1 };
            int[] nums2 = new int[] { 1, 3, 4, 2 };
            Console.WriteLine(string.Join(",", NextGreaterElement(nums1, nums2))); //Expected: [-1,3,-1]
        }
        
        //This method works by iterating through each element in `nums1` and using the helper method `Solve`
        //to find the next greater element. `Solve` finds the index of the current element in `nums2` and
        //then searches for the first element that is greater than the current element starting from that index.
        //If no such element is found, it returns -1.

        private static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int[] res = new int[nums1.Length];
            for(int i = 0; i < nums1.Length; i++)
            {
                res[i] = Solve(nums1[i], nums2);
            }
        
            return res;
        
            int Solve(int num, int[] nums)
            {
                int index = Array.IndexOf(nums2, num);
                if(index == -1 || index == nums2.Length-1) return -1;
             
                for(int i=index; i<nums2.Length; i++)
                    if(nums2[i] > num) return nums2[i];
            
                return -1;
            }
        }
    }
}