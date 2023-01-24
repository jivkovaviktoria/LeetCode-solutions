using System;
using System.Collections.Generic;
using System.Linq;

namespace Subsets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3 };

            foreach(var s in Subsets(nums).ToList())
                Console.WriteLine(string.Join(",", s));
            
            //Expected: [[],[1],[2],[1,2],[3],[1,3],[2,3],[1,2,3]]
        }
        
        public static IList<IList<int>> Subsets(int[] nums) {
            var result = new List<IList<int>>();
            DFS(nums, 0, new List<int>(), result);
            return result;
        
            void DFS(int[] nums, int start, IList<int> oneResult, IList<IList<int>> result)
            {
                result.Add(new List<int>(oneResult));

                for (int i = start; i < nums.Length; i++) {
                    oneResult.Add(nums[i]);
                    DFS(nums, i + 1, oneResult, result);
                    oneResult.RemoveAt(oneResult.Count - 1);
                }
            }
        }
    }
}