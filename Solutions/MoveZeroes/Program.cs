using System;

namespace MoveZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 0, 3, 12};
            MoveZeroes(nums); //Expected: 1, 3, 12, 0, 0
        }

        //We have two variables i and j which are used to iterate through the array
        //i is used ti iterate the array from left to right, while j is used to keep track
        //where the next non-zero element should be placed. 
        //f the current element is not zero, the element is copied to index j and j is incremented
        //The variable i is always incremented at the end of each iteration
        //after the first loop we enter to the another where we start from j and continue while j is less than the array length
        // in his loop we add the zeroes to the end of the array(nums[j] = 0)
        private static void MoveZeroes(int[] nums) {
            
            int i = 0;
            int j = 0;
        
            while(i < nums.Length)
            {
                if(nums[i] != 0)
                {
                    nums[j] = nums[i];
                    j++;
                }
                i++;
            }
        
            while(j < nums.Length)
            {
                nums[j] = 0;
                j++;
            }
        }
    }
    
}