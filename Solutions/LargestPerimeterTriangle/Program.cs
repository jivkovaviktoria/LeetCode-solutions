using System;

namespace LargestPerimeterTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 1, 2 };
            Console.WriteLine(LargestPerimeter(nums)); //Expected: 5
        }
        
        //We sort the array descending
        
        // ! - The triangle inequality theorem states that any side of a triangle is
        //always shorter than the sum of the other two sides.
        
        //We start to check from the largest side, if we find a side
        //that is shorter than the sum of the other two - we return the perimeter
        //If not we return 0
        private static int LargestPerimeter(int[] nums) {

            Array.Sort(nums, (a1, a2) => a2.CompareTo(a1));
            
            for(int i = 0; i < nums.Length - 2; i++)
            {
                if(nums[i] < nums[i + 1] + nums[i + 2])
                {
                    return nums[i] + nums[i + 1] + nums[i + 2];
                }
            }

            return 0;
        }
    }
}