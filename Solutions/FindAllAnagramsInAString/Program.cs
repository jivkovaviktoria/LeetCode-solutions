using System;
using System.Collections.Generic;
using System.Linq;

namespace FindAllAnagramsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "cbaebabacd", p = "abc";
            Console.WriteLine(string.Join(",", FindAnagrams(s, p)));
            //Expected: [0,6]
        }
        
        public static IList<int> FindAnagrams(string s, string p) {
            if (s.Length < p.Length) return new List<int>();
        
            List<int> res = new List<int>();
            int[] freqS = new int[26];
            int[] freqP = new int[26];
            char[] charP = p.ToCharArray();
        
            for (int i = 0; i < p.Length; i ++) freqP[charP[i] - 'a'] ++;
        
            for (int i = 0; i < s.Length - p.Length + 1; i ++)
            {
                if (!p.Contains(s.Substring(i, 1))) continue;
                if (IsAnagram(s.Substring(i, p.Length), p)) res.Add(i);
            }

            return res;
        
            bool IsAnagram(string sub, string p)
            {
                freqS = new int[26];
                char[] charS = sub.ToCharArray();
                for (int i = 0; i < sub.Length; i ++) freqS[charS[i] - 'a'] ++;
            
                return Enumerable.SequenceEqual(freqS, freqP);
            }
        }
    }
}