using System;
using System.Collections.Generic;
using System.Linq;

namespace MajorityElementII
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 3, 2, 3 };
            Console.WriteLine(MajorityElement(nums)); //Expected: 3
        }
        
        public static IList<int> MajorityElement(int[] nums) {
            int n = nums.Length/3;
            HashSet<int> ans = new HashSet<int>();
        
            Dictionary<int, int> d = new Dictionary<int, int>();
        
            for(int i = 0; i < nums.Length; i++){
                if(d.ContainsKey(nums[i]) == false) d.Add(nums[i], 0);
                d[nums[i]]++;
            
                if(d[nums[i]] > n) ans.Add(nums[i]);
            }
        
            return ans.ToList();
        }
    }
}