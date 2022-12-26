using System;

namespace JumpGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 1, 0, 4, 5 };
            Console.WriteLine(CanJump(nums)); //Expected: false
        }

        //This method determines if it is possible to jump from the first element in the given array of integers
        //to the last element. It does this by iterating through the array and keeping track of the maximum number
        //of steps that can be taken at each element. If the current element is 0 and the maximum number of steps
        //that can be taken is also 0, then it is not possible to jump past this element and the method returns false.
        //If the current element is greater than or equal to the maximum number of steps that can be taken, then the maximum
        //number of steps is updated to the value of the current element. Finally, the maximum number of steps is decremented
        //by 1 at the end of each iteration
        private static bool CanJump(int[] nums) {
            int max = 0;
            for(int i = 0; i < nums.Length-1; i++)
            {
                if(nums[i] == 0 && max == 0) return false;
                if(nums[i] >= max) max = nums[i];
                max--;
            }
        
            return true;
        }
    }
}