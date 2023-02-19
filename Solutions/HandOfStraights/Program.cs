using System;
using System.Collections.Generic;
using System.Linq;

namespace HandOfStraights
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hand = new int[] { 1, 2, 3, 6, 2, 3, 4, 7, 8 };
            Console.WriteLine(IsNStraightHand(hand, 3)); //Expected: true
        }
        
        public static bool IsNStraightHand(int[] hand, int groupSize) {
            SortedDictionary<int, int> d = new SortedDictionary<int, int>();
        
            foreach(var card in hand)
            {
                if(d.ContainsKey(card) == false) d.Add(card, 0);
                d[card]++;
            }
        
            while(d.Count > 0)
            {
                var start = d.Keys.First();
                var size = groupSize;
            
                while(size > 0)
                {
                    if (d.ContainsKey(start))
                    {
                        d[start]--;
                        if (d[start] == 0) d.Remove(start);
                    }
                    else return false;
                
                    start++;
                    size--;
                }
            }
        
            return true;
        }
    }
}