using System;

namespace RemoveOneElementToMakeTheArrayStrictlyIncreasing
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 10, 5, 7 };
            Console.WriteLine(CanBeIncreasing(nums)); //Expected: true

            int[] nums2 = new int[] { 2, 3, 1, 2 };
            Console.WriteLine(CanBeIncreasing(nums2)); //Expected: false
        }
        
         public static bool CanBeIncreasing(int[] nums) {
               
                int count = 0;
                for (int i = 1; i < nums.Length && count < 2; i++)
                {
                    if (nums[i-1] >= nums[i])
                    {
                        count++;
                        if (i > 1 && nums[i - 2] >= nums[i])
                            nums[i] = nums[i - 1];
                    }
                }
                
                
                return count < 2;
            }
    }
}