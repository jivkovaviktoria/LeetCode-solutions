using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace MostFrequentEvenElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 1, 2, 2, 4, 4, 1 };
            Console.WriteLine(MostFrequentEven(nums)); //Expected: 2
        }
        
        public static int MostFrequentEven(int[] nums) {
            Dictionary<int, int> d = new Dictionary<int,int>();
        
            for(int i = 0; i < nums.Length; i++){
                if(d.ContainsKey(nums[i]) == false) d.Add(nums[i], 0);
                d[nums[i]]++;
            }
        
            var result = d.Where(x => x.Key % 2 == 0).OrderByDescending(x => x.Value).ThenBy(x => x.Key).FirstOrDefault().Key;
        
            if(result == 0 && d.Keys.Contains(0) == false) return -1;
            return result;
        }
    }
}