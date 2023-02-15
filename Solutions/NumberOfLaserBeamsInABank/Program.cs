using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberOfLaserBeamsInABank
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bank = new string[] { "000","111","000"};
            Console.WriteLine(NumberOfBeams(bank));
        }
        
        public static int NumberOfBeams(string[] bank) {
                SortedDictionary<int, int> map = new SortedDictionary<int, int>();
                
                for(int i = 0; i < bank.Length; i++){
                    map.Add(i, 0);
                    for(int j = 0; j < bank[i].Length; j++){
                        if(bank[i][j] == '1') map[i]++;
                    }
                }
        
                var values = map.Values.Where(x => x != 0).ToList();
                int ans = 0;
                for (int i = 0; i < values.Count-1; i++)
                    ans += values[i] * values[i + 1];
                        
                return ans;
            }
    }
}