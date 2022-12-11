using System;

namespace SqrtX
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 8;
            Console.WriteLine(MySqrt(x)); //Expected: 2
        }
        
        private static int MySqrt(int x)
        {

            double root = 1;
            int i = 0;

            while (true)
            {
                i = i + 1;
                if(root == (x / root + root) / 2) break;
                
                root = (x / root + root) / 2;
                if (i == x + 1) break;
            }

            return (int)root;
        }
    }
}