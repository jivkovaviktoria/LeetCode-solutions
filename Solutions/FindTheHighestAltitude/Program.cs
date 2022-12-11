using System;

namespace FindTheHighestAltitude
{
    class Program
    {
        static void Main(string[] args)
        {
            var gain = new int[] { -5, 1, 5, 0, -7 };
            
            Console.WriteLine(LargestAltitude(gain));
            //Expected: 1
        }

        private static int LargestAltitude(int[] gain) {
            if(gain == null || gain.Length == 0) return 0;

            int current = 0;
            int max = 0;
            for(int i = 0; i < gain.Length; i++)
            {
                current += gain[i];
                if(current > max) max = current;
            }

            return max;
        }
    }
}