using System;

namespace PowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 16;
            int n2 = 3;

            Console.WriteLine(IsPowerOfTwo(n)); //Expected: true
            Console.WriteLine(IsPowerOfTwo(n2)); //Expected: false
        }
        
        /// <summary>
        /// This method checks if the given number is power of 2
        /// </summary>
        /// <param name="number"></param>
        /// <returns>bool</returns>
        public static bool IsPowerOfTwo(int number) {
            if(number < 1) return false;
            while(number > 1){
                if(number%2 != 0) return false;
                number/=2;
            }
        
            return true;
        }
    }
}