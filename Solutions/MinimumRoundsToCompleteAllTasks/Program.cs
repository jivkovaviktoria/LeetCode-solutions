using System;
using System.Collections.Generic;

namespace MinimumRoundsToCompleteAllTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tasks = new int[] { 2, 2, 3, 2, 3, 4, 4, 4, 4, 4};
            Console.WriteLine(MinimumRounds(tasks)); //Expected: 4
        }

        //First we create a dictionary map that maps an integer to the number of times it appears in the tasks array.
        //Then we iterate through the values in map and do the following:
        //If the value is 1, we return -1 immediately.
        //If the value is divisible by 3, we add the value divided by 3 to the `ans` variable.
        //If the value is not divisible by 3, we add the value divided by 3 plus 1 to the `ans` variable.
        //Finally, we return the value of `ans` .
        private static int MinimumRounds(int[] tasks) {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i = 0; i < tasks.Length; i++)
            {
                if(map.ContainsKey(tasks[i]) == false) map.Add(tasks[i], 0);
                map[tasks[i]]++;
            }
        
            int ans = 0;
            foreach(var num in map.Values)
            {
                if(num == 1) return -1;
                else if(num % 3 == 0) ans += num/3;
                else ans += num/3+1;       
            }
        
            return ans;
        }
    }
}