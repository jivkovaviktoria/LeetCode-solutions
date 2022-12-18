using System;
using System.Collections.Generic;

namespace CheckIfOneStringSwapCanMakeStringsEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "bank", s2 = "kanb";
            
        }

        //First we check if both strings are null, in which case we return true.
        //If one of the strings is null and the other is not,we return false.

        //Next we iterate over the characters in s1, and compare them to the
        //corresponding characters in s2. If a character in s1 is different from the
        //corresponding character in s2, we add the index of the character
        //to a list of differences. If the list of differences already has two or more elements,
        //we return false, because it is not possible for the strings to be almost equal
        //if they differ by more than two characters.

        //Finally, we check the size of the list of differences.
        //If the list is empty, it means that the strings are identical (returns true)
        //If the list has two elements, we check whether the characters at those indices
        //in s1 and s2 are transpositions of each other. If they are, we return true,
        //otherwise - false.
        
        private static bool AreAlmostEqual(string s1, string s2)
        {
            if(s1 == null && s2 == null) return true;
            else if(s1 == null || s2 == null) return false;
               
            List<int> diff = new List<int>();
            for(int i = 0; i < s1.Length; i++)
            {
                if(s1[i] != s2[i])
                {
                    diff.Add(i);
                    if(diff.Count > 2) return false;
                }
            }
        
            return diff.Count == 0 || diff.Count == 2 && s1[diff[0]] == s2[diff[1]] && s1[diff[1]] == s2[diff[0]];
        }
    }
}