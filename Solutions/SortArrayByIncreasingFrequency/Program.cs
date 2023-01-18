using System;
using System.Collections.Generic;
using System.Linq;

namespace SortArrayByIncreasingFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 2, 2, 2, 3 };
            Console.WriteLine(string.Join(",", FrequencySort(nums))); //Expected: [3,1,1,2,2,2]

            int[] nums2 = new int[] { 2, 3, 1, 3, 2 };
            Console.WriteLine(string.Join(",", FrequencySort(nums2))); //Expected: [1,3,3,2,2]
        }
        
        //We count the frequency of each number using dictionary
        //Then sort the array by the frequency count of each number, and in case of a tie, we sort the numbers
        //in descending order
        public static int[] FrequencySort(int[] nums) {
            Dictionary<int, int> freq = new Dictionary<int, int>();
        
            for(int i = 0; i < nums.Length; i++){
                if(freq.ContainsKey(nums[i]) == false) freq.Add(nums[i], 0);
                freq[nums[i]]++;
            }
        
            return nums.OrderBy(x => freq[x]).ThenByDescending(x => x).ToArray();
        }
    }
}