using System;
using System.Linq;
using System.Threading.Channels;

namespace LargestNumberAtLeastTwiceOfOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 6, 1, 0 };
            Console.WriteLine(DominantIndex(nums)); //Expected: 1
        }
        
        // First we find the largest element in nums
        // Then we iterate through the array and check if the element is at least twice greater than the element
        // If it is not, we return =1;
        public static int DominantIndex(int[] nums) {
            int max = nums.OrderByDescending(x => x).First();
        
            int index = 0;
            for(int i = 0; i < nums.Length; i++){
                if(nums[i] == max) index = i;
                else if((nums[i]*2 <= max) == false) return -1;
            }
        
            return index;
        }
    }
}