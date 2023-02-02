using System;

namespace RemoveDuplicatesFromSortedArrayII
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };
            Console.WriteLine(RemoveDuplicates(nums)); //Expected: 5 , nums = [1,1,2,2,3,_]
        }
        
        public static int RemoveDuplicates(int[] nums) {
            int i = 0; 
            foreach (var n in nums){ 
                if (i < 2 || n > nums[i-2]) { 
                    nums[i] = n; 
                    i++;
                }
            }
            
            return i;
        }
    }
}