using System;
using System.Collections.Generic;
using System.Linq;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3 };
            var result = Permute(nums);
            
            foreach(var p in result) Console.WriteLine(string.Join(",", p));
            //Expected: [[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
        }
        
        public static IList<IList<int>> Permute(int[] nums) {
            List<IList<int>> ans = new List<IList<int>>();
            Solve(ans, 0, nums);
            return ans;
        
            void Solve(List<IList<int>> ans, int index, int[] nums){
                if(index == nums.Length){
                    ans.Add(nums.ToList());
                    return;
                }
            
                for(int i = index; i < nums.Length; i++){
                    var temp = nums[index];
                    nums[index] = nums[i];
                    nums[i] = temp;
                
                    Solve(ans, index + 1, nums);
                
                    temp = nums[index];
                    nums[index] = nums[i];
                    nums[i] = temp;
                }
            }
        
        }
    }
}