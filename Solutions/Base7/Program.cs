using System;
using System.Text;

namespace Base7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            Console.WriteLine(ConvertToBase7(num)); //Expected: 202

            int num2 = -7;
            Console.WriteLine(ConvertToBase7(num2)); //Expected: -10
        }
        
        public static string ConvertToBase7(int num)
        {
            if (num == 0) return "0";
        
            int n = Math.Abs(num);
        
            StringBuilder sb = new StringBuilder();
        
            while (n != 0)
            {
                var digit = n % 7;
                sb.Insert(0, digit);
                n /= 7;
            }
        
            if (num < 0) sb.Insert(0, "-");
            return sb.ToString();
        }
    }
}