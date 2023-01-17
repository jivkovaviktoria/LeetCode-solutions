using System;
using System.Collections.Generic;
using System.Linq;

namespace MajorityElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] { 3, 2, 3 };
            Console.WriteLine(MajorityElement(nums)); //Expected: 3

            int[] nums2 = new int[] { 2, 2, 1, 1, 1, 2, 2 };
            Console.WriteLine(MajorityElement(nums2)); //Expected: 2
        }
        
        //We use a Dictionary to count the frequency of each element in the input array. Then iterate through
        //the dictionary and return the key of the first element whose frequency is greater than or equal to half the length
        //of the input array. If no such element is found, return -1.
        public static int MajorityElement(int[] nums) {
            Dictionary<int, int> f = new Dictionary<int, int>();
        
            for(int i = 0; i < nums.Length; i++)
            {
                if(f.ContainsKey(nums[i]) == false) f.Add(nums[i], 0);
                f[nums[i]]++;
            }
        
            foreach(var (key, value) in f.OrderByDescending(x => x.Value))
                if(value >= nums.Length/2) return key;
        
            return -1;
        }
    }
}