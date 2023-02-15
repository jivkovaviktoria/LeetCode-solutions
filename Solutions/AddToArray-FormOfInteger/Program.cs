using System;
using System.Collections.Generic;
using System.Linq;

namespace AddToArray_FormOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 0, 0 };
            int k = 34;

            Console.WriteLine(AddToArrayForm(nums, k)); //Expected: [1,2,3,4]
        }
        
        public static IList<int> AddToArrayForm(int[] num, int k) {
            List<int> ans = new List<int>();

            Stack<int> digits = new Stack<int>();
            for (int i = num.Length - 1; i >= 0; i--)
            {
                int x = num[i] + k;
                digits.Push(x % 10);
                k = x / 10;
            }

            while (k > 0)
            {
                digits.Push(k % 10);
                k = k / 10;
            }

            while(digits.Any()){
                ans.Add(digits.Pop());
            }
        
            return ans;
        }
    }
}