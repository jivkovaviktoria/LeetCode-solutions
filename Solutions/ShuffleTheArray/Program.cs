using System;

namespace ShuffleTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 5, 1, 3, 4, 7 };
            int n = 3;
            Console.WriteLine(string.Join(",", Shuffle(nums, n))); //Expected: [2,3,5,4,1,7] 
        }
        
        public static int[] Shuffle(int[] nums, int n) {
        
            int[] res = new int[n * 2];

            for (int i = 0; i < n; i++)
            {
                res[i * 2] = nums[i];
                res[i * 2 + 1] = nums[i + n];
            }

            return res;
        }
    }
}