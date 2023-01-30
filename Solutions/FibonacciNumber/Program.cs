using System;

namespace FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            Console.WriteLine(Fib(n)); //Expected: 2
        }
        
        /// <summary>
        /// This method calculates fibonacci of n
        /// </summary>
        /// <param name="n"></param>
        /// <returns>int</returns>
        public static int Fib(int n) {
            if(n <= 0) return 0;
        
            int a = 0, b = 1, c = 1;
        
            for(int i = 1; i < n; i++){
                c = a + b;
                a = b;
                b = c;
            }
        
            return c;
        }
    }
}