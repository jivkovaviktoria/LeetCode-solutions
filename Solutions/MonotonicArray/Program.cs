using System;

namespace MonotonicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 2 };
            Console.WriteLine(IsMonotonic(nums)); //Expected: false
        }

        //The method starts by setting two boolean variables, incr and decr, to true. These variables are used to track
        //whether the array is strictly increasing or strictly decreasing. The method then iterates through the array
        //and compares each element to the next element. If the current element is greater than the next element, then incr
        //is set to false. If the current element is less than the next element, then decr is set to false. This continues
        //for each element in the array.

        //After the loop finishes, the method checks if either incr or decr is still true. If either of them is true, then
        //the array is monotonic and the method returns true. Otherwise, both incr and decr are false and the method returns
        //false, indicating that the array is not monotonic.
        private static bool IsMonotonic(int[] nums) {
            bool incr = true, decr = true;
            for(int i = 0; i < nums.Length-1; i++)
            {
                if(nums[i] > nums[i+1]) incr = false;
                if(nums[i] < nums[i+1]) decr = false;
            }
        
            if(incr || decr) return true;
        
            return false;
        }
    }
}