using System;
using System.Collections.Generic;

namespace FindCenterOfStarGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] edges = new int[3][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 4, 2 }
            };

            Console.WriteLine(FindCenter(edges)); //Expected: 2
        }
        
        public static int FindCenter(int[][] edges) {
            int count = edges.Length;
        
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i= 0; i < count; i++)
            {
                if(map.ContainsKey(edges[i][0]) == false) map.Add(edges[i][0], 0);
                map[edges[i][0]]++;
            
                if(map.ContainsKey(edges[i][1]) == false) map.Add(edges[i][1], 0);
                map[edges[i][1]]++;
            }
        
            foreach(var (k,v) in map)
                if(v == count) return k;
        
            return -1;
        }
    }
}