using System;
using System.Collections.Generic;

namespace UncommonWordsFromTwoSentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "this apple is sweet", s2 = "this apple is sour";
            Console.WriteLine(string.Join(",", UncommonFromSentences(s1 ,s2)));
            //Expected: ["sweet","sour"]
        }
        
        public static string[] UncommonFromSentences(string s1, string s2) {
            Dictionary<string, int> map = new Dictionary<string,int>();
            List<string> result = new List<string>();
        
            foreach(string word in s1.Split()){
                if(!map.ContainsKey(word)) map.Add(word, 1);
                else map[word]++;
            }
        
            foreach(string word in s2.Split()){
                if(!map.ContainsKey(word)) map.Add(word, 1);
                else map[word]++;
            }
        
            foreach(var pair in map)
                if(pair.Value == 1) result.Add(pair.Key);
        
            return result.ToArray();
        }
    }
}