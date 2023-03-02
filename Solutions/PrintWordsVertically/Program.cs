using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintWordsVertically
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "HOW ARE YOU";
            Console.WriteLine(string.Join(", ", PrintVertically(s)));
            //Expected: ["HAY","ORO","WEU"]
        }
        
        public static IList<string> PrintVertically(string s) {
            var whitespace = ' ';
            var words = s.Split(whitespace, StringSplitOptions.RemoveEmptyEntries);
        
            var max = words.Select(x => x.Length).Max();
        
            return Enumerable
                .Range(0, max)
                .Select(i => string.Join(string.Empty, words.Select(x => i < x.Length ? x[i] : whitespace)).TrimEnd())
                .ToList();
        }
    }
}