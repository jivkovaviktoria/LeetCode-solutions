using System;

namespace GasStation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] gas = new int[] { 1, 2, 3, 4, 5 };
            int[] cost = new int[] { 3, 4, 5, 1, 2 };

            Console.WriteLine(CanCompleteCircuit(gas, cost)); //Expected: 3
        }
        
        public static int CanCompleteCircuit(int[] gas, int[] cost) {
        
            int start = 0, sum = 0, total = 0;
        
            for(int i = 0; i < gas.Length; i++)
            {
                sum = sum + (gas[i] - cost[i]);
                if(sum < 0)
                {
                    total = total + sum;
                    sum = 0;
                    start = i + 1;
                }
            }
        
            total = total + sum;
        
            if(total >= 0) return start;
            return -1;
        }
    }
}