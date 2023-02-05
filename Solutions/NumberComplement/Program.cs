using System;
using System.Linq;

namespace NumberComplement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 1;
            Console.WriteLine(FindComplement(num2)); //Expected: 2
            Console.WriteLine(FindComplement(num2)); //Expected: 0
        }
        
        public static int FindComplement(int num) 
         => Convert.ToInt32(string.Join("", Convert.ToString(num, 2).Select(x => x == '0' ? '1' : '0')), 2);
        
    }
}