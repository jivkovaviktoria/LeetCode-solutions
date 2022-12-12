using System;

namespace RemoveDuplicatesFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0,0,1,1,1,2,2,3,3,4};
            Console.WriteLine(RemoveDuplicates(nums)); //Expected: 5
            
            //Expected (nums) - [0,1,2,3,4,_,_,_,_,_];
        }

        //Index represents where we should put the new number
        //It starts with 1 because the first number always gonna be unique
        //we will always start placing them after the first number
        //We loop through all numbers and check if they are the same
        //If they aren't, we place the number at the index and increase it
        private static int RemoveDuplicates(int[] nums) {
                
                int index = 1;
                for(int i = 0; i < nums.Length - 1; i++)
                {
                    if(nums[i] != nums[i+1])
                        nums[index++] = nums[i+1];
                }
        
                return index;
        }
    }
}