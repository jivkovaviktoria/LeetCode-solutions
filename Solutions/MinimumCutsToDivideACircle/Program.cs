using System;

namespace MinimumCutsToDivideACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 4;
            Console.WriteLine(NumberOfCuts(n)); //Expected: 2
        }

        //We want to cut the circle in n equal parts so the only posible ways are:
        
        //If n is 1 we don't need to cut it
        //If n is even - to cut it n/2 times
        //If n is odd - to cut it n times
        private static int NumberOfCuts(int n)
        {
            if(n == 1) return 0;
            if(n%2 == 0) return n/2;
            else return n;
        }
    }
}