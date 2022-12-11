using System;
using System.Linq;

namespace CountWordsWIthGivenPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new string[] { "pay", "attention", "practice", "attend" };
            var pref = "at";

            Console.WriteLine(PrefixCount(words, pref));
            //Expected: 2
        }

        private static int PrefixCount(string[] words, string pref) {
            return words.Count(x => x.StartsWith(pref));
        }
    }
}