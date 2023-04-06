using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumNumberOfBalloons
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "loonbalxballpoon";
            Console.WriteLine(MaxNumberOfBalloons(text)); //Expected: 2
        }
        
        public static int MaxNumberOfBalloons(string text) {
            Dictionary<char, int> d = new Dictionary<char, int>{{'b', 0},{'a', 0},{'l', 0},{'o', 0}, {'n', 0}};
        
            foreach(var c in text){
                if(d.ContainsKey(c)) d[c]++;
            }
        
            d['o']/=2;
            d['l']/=2;
        
            return d.Values.Min();
        }
    }
}