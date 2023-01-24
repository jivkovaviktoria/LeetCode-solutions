using System;
using System.Collections.Generic;

namespace FindTheTownJudge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int[][] trust = new int[][] { new int[] { 1, 2 } };

            Console.WriteLine(FindJudge(n, trust)); //Expected: 2
        }
        
        public static int FindJudge(int n, int[][] trust) {
            var map = new Dictionary<int,HashSet<int>>();
        
            for(int i =1; i <=n; i++)
                map[i] = new HashSet<int>();
            
            for(int i = 0; i < trust.Length; i++)
            {
                map[trust[i][0]].Add(trust[i][1]);
            }
        
            int judge = -1;   
     
            foreach(var item in map)
            {
                if(map[item.Key].Count == 0)
                    judge = item.Key;
            }
        
            for(int i = 1; i <=n; i++)
            {
                if(!map[i].Contains(judge) && judge != i)
                    return -1;
            }
        
        
            return judge; 
        }
    }
}