using System;

namespace UglyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6;
            Console.WriteLine(IsUgly(n)); //Expected: true

            int n2 = 14;
            Console.WriteLine(IsUgly(n2)); //Expected: false
        }
        
        public static bool IsUgly(int n) {
            if (n <= 0) return false;

            while (n > 0)
            {
                if (n % 2 == 0){
                    n = n / 2;
                    continue;
                }
                if (n % 3 == 0){
                    n = n / 3;
                    continue;
                }
                if (n % 5 == 0){
                    n = n / 5;
                    continue;
                }
                break;
            }

            if (n == 1) return true;
            return false;
        }
    }
}