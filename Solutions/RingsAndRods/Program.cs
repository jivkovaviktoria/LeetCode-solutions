using System;
using System.Collections.Generic;

namespace RingsAndRods
{
    class Program
    {
        static void Main(string[] args)
        {
            string rings = "B0B6G0R6R0R6G9";
            Console.WriteLine(CountPoints(rings)); //Expected: 1
        }
        
        public static int CountPoints(string rings) {
            Dictionary<int, HashSet<char>> dic = new Dictionary<int, HashSet<char>>();
        
            for(int i = 0; i < rings.Length; i+=2)
            {
                var ring = rings[i+1] - '0';
                var color = rings[i];
                if(dic.ContainsKey(ring) == false) dic.Add(ring, new HashSet<char>());
                dic[ring].Add(color);
            }
        
            int ans = 0;
            foreach(var (rod, hs) in dic)
            {
                if(hs.Count == 3)
                    ans++;
            }
        
            return ans;
        
        }
    }
}