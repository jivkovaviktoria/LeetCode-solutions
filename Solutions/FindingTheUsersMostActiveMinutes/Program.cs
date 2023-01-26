using System;
using System.Collections.Generic;

namespace FindingTheUsersMostActiveMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] logs = new int[][]
            {
                new int[] { 0, 5 },
                new int[] { 1, 2 },
                new int[] { 0, 2 },
                new int[] { 0, 5 },
                new int[] { 1, 3 }
            };

            int k = 5;

            Console.WriteLine(string.Join(",", FindingUsersActiveMinutes(logs, k)));
            // Expected: [0,2,0,0,0]
        }
        
        public static int[] FindingUsersActiveMinutes(int[][] logs, int k) {
            int[] ans = new int[k];
        
            Dictionary<int, HashSet<int>> map = new Dictionary<int, HashSet<int>>();
        
            for(int i = 0; i < logs.Length; i++){
                if(map.ContainsKey(logs[i][0]) == false) map.Add(logs[i][0], new HashSet<int>());
                map[logs[i][0]].Add(logs[i][1]);
            }
        
            foreach(var (key, value) in map){
                ans[value.Count-1]++;
            }
        
            return ans;
        }
    }
}