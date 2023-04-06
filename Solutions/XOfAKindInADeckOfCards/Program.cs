using System;
using System.Collections.Generic;
using System.Linq;

namespace XOfAKindInADeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] deck = new int[] { 1, 2, 3, 4, 4, 3, 2, 1 };
            Console.WriteLine(HasGroupsSizeX(deck)); //Expected: true
        }
        
        public static bool HasGroupsSizeX(int[] deck) {
            Dictionary<int, int> d = new Dictionary<int, int>();
        
            foreach(var num in deck){
                if(d.ContainsKey(num) == false) d.Add(num, 0);
                d[num]++;
            }
        
            long min = d.Min(x => x.Value);
            if(min < 2) return false;
        
            foreach(var (key, value) in d){
                min = FindGCD(min, value);
            }
        
            return min > 1;
        }
    
    
        private static long FindGCD(long a, long b)
        {
            if (a == 0) return b;
            return FindGCD(b % a, a);
        }
    }
}