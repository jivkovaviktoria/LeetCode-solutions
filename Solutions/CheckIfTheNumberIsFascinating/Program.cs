using System;
using System.Collections.Generic;

namespace CheckIfTheNumberIsFascinating
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 192;
            Console.WriteLine(IsFascinating(num)); //Expected: true
        }
        
        public static bool IsFascinating(int x1) {
            HashSet<int> nums = new HashSet<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9};
        
            var x2 = x1*2;
            var x3 = x1*3;
        
            while(x1 > 0 && x2 > 0 && x3 > 0){
                nums.Remove(x1%10);
                nums.Remove(x2%10);
                nums.Remove(x3%10);
            
                x1/=10;
                x2/=10;
                x3/=10;
            }
        
            return nums.Count == 0;
        }
    }
}