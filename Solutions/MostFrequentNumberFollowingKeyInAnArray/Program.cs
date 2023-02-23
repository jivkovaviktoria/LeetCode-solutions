using System;
using System.Collections.Generic;
using System.Linq;

namespace MostFrequentNumberFollowingKeyInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 100, 200, 1, 100 };
            int key = 1;
            Console.WriteLine(MostFrequent(nums, key)); //Expected: 100
        }
        
        public static int MostFrequent(int[] nums, int key) {
            Dictionary<int, int> d = new Dictionary<int, int>();
        
            for(int i = 0; i < nums.Length-1;i++){
                if(nums[i] == key){
                    if(d.ContainsKey(nums[i+1]) == false) d.Add(nums[i+1], 0);
                    d[nums[i+1]]++;
                }
            }
        
            return d.OrderByDescending(x => x.Value).First().Key;
        }
    }
}