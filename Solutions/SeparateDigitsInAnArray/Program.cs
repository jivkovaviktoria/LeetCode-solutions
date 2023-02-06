using System;
using System.Collections.Generic;
using System.Linq;

namespace SeparateDigitsInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 13, 25, 83, 77 };
            Console.WriteLine(string.Join(",", SeparateDigits(nums))); //Expected: [1,3,2,5,8,3,7,7]
        }
        
        public static int[] SeparateDigits(int[] nums) {
            List<int> ans = new List<int>();
        
            foreach(var num in nums){
                Stack<int> digits = new Stack<int>();
                if(num < 10) ans.Add(num);
                else{
                    var x = num;
                    while(x > 0){
                        digits.Push(x%10);
                        x/=10;
                    }
                
                    while(digits.Any()) ans.Add(digits.Pop());
                }
            }
        
            return ans.ToArray();
        }
    }
}