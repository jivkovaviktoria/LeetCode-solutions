using System;

namespace MinimumOperationsToMakeArrayEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            Console.WriteLine(MinOperations(n)); //Expected: 2
        }
        
        public static int MinOperations(int n) {
            int middleIndex = n / 2;
            if (n % 2 == 1) return middleIndex * middleIndex + middleIndex;
	 
            middleIndex -= 1;
            return middleIndex * (middleIndex + 1) + middleIndex + 1;
        }
    }
}