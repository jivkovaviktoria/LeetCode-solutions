using System;

namespace PowerOfFour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 16;
            int n2 = 5;

            Console.WriteLine(IsPowerOfFour(n)); //Expected: true
            Console.WriteLine(IsPowerOfFour(n2)); //Expected: false
        }
            
        /// <summary>
        /// This method ckecks if a given number is a power of 4.
        /// </summary>
        /// <param name="number"></param>
        /// <returns>bool</returns>
        public static bool IsPowerOfFour(int number) {
            if (number < 1) return false;
            
            while(number > 1) {
                if(number%4 != 0) return false;
                number /= 4;
            }
            return true;
        }   
    }
}