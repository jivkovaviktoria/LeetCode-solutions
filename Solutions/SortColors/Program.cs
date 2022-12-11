using System;

namespace SortColors
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 2, 0, 2, 1, 1, 0 };
            
            SortColors(nums);
            Console.WriteLine(string.Join(",", nums)); //Expected: [0,0,1,1,2,2]
        }

        private static void SortColors(int[] nums) {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
                    i = -1;
                }
            }
        }
    }
}