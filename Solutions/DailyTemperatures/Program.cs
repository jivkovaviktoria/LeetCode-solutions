using System;
using System.Collections.Generic;

namespace DailyTemperatures
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };
            Console.WriteLine(string.Join(",", DailyTemperatures(input))); //Expected:  [1, 1, 4, 2, 1, 1, 0, 0]
        }

        //The method uses a stack to keep track of the indices of the temperatures.
        //It iterates through the array of temperatures, and for each temperature,
        //it pops all the indices from the stack for which the temperature is less
        //than the current temperature. The popped indices are replaced with the number
        //of days it would take for a warmer temperature.
        //The current index is then pushed onto the stack.

        //After the iteration is complete, the method replaces all the remaining indices
        //in the stack with 0. This is because if there are no warmer temperatures, the number of days to wait is 0.
        
        private static int[] DailyTemperatures(int[] temperatures) {
            
            Stack<int> s = new Stack<int>();
            
            int[] ans = new int[temperatures.Length];
        
            for(int i = 0; i < temperatures.Length; i++)
            {
                while(s.Count > 0 && temperatures[s.Peek()] < temperatures[i])
                {
                    int colderDayIndex = s.Pop();
                    ans[colderDayIndex] = i - colderDayIndex;   
                }
            
                s.Push(i);
            }
        
            while(s.Count > 0) ans[s.Pop()] = 0;
        
            return ans;
        }
    }
}