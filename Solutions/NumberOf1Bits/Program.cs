using System;

namespace NumberOf1Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = 00000000000000000000000000001011;
            Console.WriteLine(HammingWeight(n)); //Expected: 3
        }

        //We use a bitwise & operator to isolate the rightmost bit in n,
        //then check if it is equal to 1. If it is, we increment `res`.
        //Then we shift n one bit to the righ (discarding the rightmost bit)
        //This process is repeated until n becomes 0. Finally, we return the value of `res`
        private static int HammingWeight(uint n) {

            int res = 0;
            while(n > 0)
            {
                uint x = n & 1;
                if(x == 1) res++;
                n = n >> 1;
            }

            return res;
        }
    }
}