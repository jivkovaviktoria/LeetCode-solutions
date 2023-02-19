using System;
using System.Linq;

namespace MostCommonWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string p = "Bob hit a ball, the hit BALL flew far after it was hit.";
            string[] banned = new string[] { "hit" };
            Console.WriteLine(MostCommonWord(p, banned)); //Expected: ball
        }
        
        public static string MostCommonWord(string paragraph, string[] banned) {
            var d = paragraph.ToLower()
                .Split(
                    new[] { ' ', ',', '.', '?', '!', '\'', ';' },
                    StringSplitOptions.RemoveEmptyEntries)
                .GroupBy(w => w)
                .ToDictionary(x => x.Key, x => x.Count());
        
            foreach(var word in banned) d.Remove(word);
            return d.OrderByDescending(x => x.Value).FirstOrDefault().Key;
        }
    }
}