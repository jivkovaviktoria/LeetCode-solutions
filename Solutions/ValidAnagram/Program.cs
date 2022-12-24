using System;
using System.Collections.Generic;

namespace ValidAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "anagram";
            var t = "nagaram";

            Console.WriteLine(IsAnagram(s, t)); //Expected: true
        }
        
        //The method first checks if the lengths of s and t are different. If they are, it returns false immediately,
        //because anagrams must have the same length.
        //Next, it creates a dictionary map that will store the frequency of each character in s. It iterates through
        //the characters in s and adds each one to the dictionary if it is not already present, or increments its count
        //if it is already in the dictionary.
        //The method then iterates through the characters in t, and for each character, it checks if it is present
        //in the dictionary. If it is not present, the method returns false, because t must have all the same characters as s.
        //If the character is present but has a count of 0 in the dictionary, the method also returns false, because all the
        //characters in t must have a corresponding character in s. If the character is present and has a count greater than 0,
        //the method decrements the count in the dictionary.
        ////Finally, after iterating through all the characters in t, the method returns true to indicate that s and t
        //are anagrams.

        private static bool IsAnagram(string s, string t) {
            if(t.Length != s.Length) return false;
        
            Dictionary<char, int> map = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++)
            {
                if(map.ContainsKey(s[i]) == false)
                    map.Add(s[i], 0);
                map[s[i]]++;
            }
        
            for(int i = 0; i < t.Length; i++)
            {
                if(map.ContainsKey(t[i]) == false) return false;
                else if(map[t[i]] == 0) return false;
            
                map[t[i]]--;
            }
        
            return true;
        }
    }
}