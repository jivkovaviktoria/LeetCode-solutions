using System;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckPerfectNumber(28)); //Expected: true
        }
        
        //A perfect number is a positive integer that is equal to the sum of its positive divisors, excluding the number
        //itself. A divisor of an integer x is an integer that can divide x evenly.
        public static bool CheckPerfectNumber(int num) {
            int sum = 0;
            for(int i = 1; i < num; i++)
                if(num % i == 0) sum += i;
        
            if(sum == num) return true;
            return false;
        }
    }
}