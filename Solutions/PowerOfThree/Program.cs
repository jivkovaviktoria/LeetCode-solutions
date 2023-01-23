using System;

namespace PowerOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 27;
            int n2 = 4;

            Console.WriteLine(IsPowerOfThree(n)); //Expected: true
            Console.WriteLine(IsPowerOfThree(n2)); //Expected: false
        }
        
        /// <summary>
        /// This method checks if the number is a power of 3
        /// </summary>
        /// <param name="number"></param>
        /// <returns>bool</returns>
        public static bool IsPowerOfThree(int number) {
            if(number < 1) return false;
            while(number > 1){
                if(number%3!=0) return false;
                number/=3;
            }
        
            return true;
        }
    }
}