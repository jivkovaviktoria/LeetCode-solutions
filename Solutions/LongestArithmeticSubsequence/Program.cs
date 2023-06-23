using System;
using System.Collections.Generic;

namespace LongestArithmeticSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 9, 4, 7, 2, 10 };
            Console.WriteLine(LongestArithSeqLength(nums)); //Expected: 3
        }
        
        public static int LongestArithSeqLength(int[] nums) {
            var ans = 1;
            Dictionary<int, int>[] map = new Dictionary<int, int>[nums.Length];
        
            for(int i = 0; i < nums.Length; i++){
                map[i] = new Dictionary<int, int>();
            
                for(int j = 0; j < i; j++){
                    int diff = nums[i] - nums[j];
                
                    if(map[j].ContainsKey(diff)) map[i][diff] = map[j][diff] + 1;
                    else map[i][diff] = 1;
                
                    ans = Math.Max(ans, map[i][diff]);
                }
            }
        
            return ans+1;
        }
    }
}