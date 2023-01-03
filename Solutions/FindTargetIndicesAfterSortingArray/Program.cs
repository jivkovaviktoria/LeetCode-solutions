using System;
using System.Collections.Generic;
using System.Linq;

namespace FindTargetIndicesAfterSortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        
        //This method takes in an array of integers called nums and an integer target. It returns a list of integers.
        //The method first creates an empty list called ans. It then loops through each element, item, in nums, which has
        //been sorted in ascending order. If an element is equal to the target, its index is added to the ans list. Finally,
        //the ans list is returned.

        private static IList<int> TargetIndices(int[] nums, int target) {
            List<int> ans = new List<int>();
        
            int index = 0;
            foreach(var item in nums.OrderBy(x => x))
            {
                if(item == target) ans.Add(index);
                index++;
            }
        
            return ans;
        }
    }
}