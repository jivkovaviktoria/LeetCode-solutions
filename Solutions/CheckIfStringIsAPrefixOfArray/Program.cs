using System;
using System.Text;

namespace CheckIfStringIsAPrefixOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "iloveleetcode";
            string[] words = new string[] { "i", "love", "leetcode", "apples" };

            Console.WriteLine(IsPrefixString(s, words)); //Expected: true
        }
        
        
        public static bool IsPrefixString(string s, string[] words) {
            StringBuilder sb = new StringBuilder();
        
            foreach(var w in words)
            {
                sb.Append(w);
                if(s == sb.ToString()) return true;
            }
        
            return false;
        }
    }
}