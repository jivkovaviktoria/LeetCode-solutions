using System;
using System.Collections.Generic;

namespace IsIsomorphic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        //We first check if the lengths of s and t are equal.
        //If they are not equal, we return false since it is not possible for two strings of different lengths to be isomorphic.
        //Then we initialize a dictionary to store the character mapping and iterate over the characters in s and t.
        //For each character, we check if the character in s has already been mapped to a character in t.
        //If it has, we check if the character in t is the same as the one that was previously mapped.
        //If the character in t is different, we return false. If the character in s has not been mapped
        //to a character in t, we check if the character in t has already been mapped to a character in s.
        //If it has, we return false. Otherwise, we add the mapping to the dictionary and continue iterating.
        //If the loop completes - return true.
        
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;
            
            var map = new Dictionary<char, char>();
            for (int i = 0; i < s.Length; i++)
            {
                char c1 = s[i];
                char c2 = t[i];
                
                if (map.ContainsKey(c1))
                {
                    if (map[c1] != c2) return false;
                }
                else
                {
                    if (map.ContainsValue(c2)) return false;
                    map.Add(c1, c2);
                }
            }
            
            return true;
        }
    }
}