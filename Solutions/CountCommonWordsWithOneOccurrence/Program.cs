using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCommonWordsWithOneOccurrence
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = new string[] { "leetcode", "is", "amazing", "as", "is" };
            string[] words2 = new string[] { "amazing","leetcode","is"};

            Console.WriteLine(CountWords(words1, words2)); //Expected: 2
        }
        
        public static int CountWords(string[] words1, string[] words2) {
            Dictionary<string, int> d1 = new Dictionary<string, int>();
            Dictionary<string, int> d2 = new Dictionary<string, int>();
        
            for(int i = 0; i < words1.Length; i++){
                if(d1.ContainsKey(words1[i]) == false) d1.Add(words1[i], 0);
                d1[words1[i]]++;
            }
        
            for(int i = 0; i < words2.Length; i++){
                if(d2.ContainsKey(words2[i]) == false) d2.Add(words2[i], 0);
                d2[words2[i]]++;
            }
        
            return d1.Count(x => x.Value == 1 && (d2.ContainsKey(x.Key) && d2[x.Key] == 1));
        }
    }
}