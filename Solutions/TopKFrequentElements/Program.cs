using System;
using System.Collections.Generic;
using System.Linq;

namespace TopKFrequentElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 1, 2, 2, 3 };
            Console.WriteLine(string.Join(",", TopKFrequent(nums, 2))); //Expected: [1,2]
        }
        
        public static int[] TopKFrequent(int[] nums, int k) {
            Dictionary<int, int> d = new Dictionary<int, int>();
        
            for(int i = 0; i < nums.Length; i++){
                if(d.ContainsKey(nums[i]) == false) d.Add(nums[i], 0);
                d[nums[i]]++;
            }
        
            int[] ans = new int[k];
            int index = 0;
            int count = 0;
        
            foreach(var (key, value) in d.OrderByDescending(x => x.Value)){
                if(count == k) break;
                ans[index] = key;
                index++;
                count++;
            }
        
            return ans;
        }
    }
}