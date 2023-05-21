using System;
using System.Collections.Generic;
using System.Linq;

namespace MinimumStringLengthAfterRemovingSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ABFCACDB";
            Console.WriteLine(MinLength(s)); //Expected: 2
        }
        
        public static int MinLength(string s) {
            Stack<char> st = new Stack<char>();
            for(int i = 0; i < s.Length; i++){
                if(st.Any() && st.Peek() == 'A' && s[i] == 'B') st.Pop();
                else if(st.Any() && st.Peek() == 'C' && s[i] == 'D') st.Pop();
                else st.Push(s[i]);
            }
        
            return st.Count;
        }
    }
}