using System;

namespace SingleElementInASortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 2, 3, 3, 4, 4, 8, 8};
            Console.WriteLine(SingleNonDuplicate(nums)); //Expected: 2
        }
        
        public static int SingleNonDuplicate(int[] nums) {
            if(nums.Length == 1) return nums[0];
        
            for(int i = 1; i < nums.Length - 1; i++){
                if(nums[i-1] != nums[i] && nums[i+1] != nums[i]) return nums[i];
            }
        
            if(nums[0] != nums[1]) return nums[0];
            else return nums[nums.Length-1];
        }
    }
}