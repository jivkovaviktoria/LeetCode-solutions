using System;
using System.Collections.Generic;
using System.Linq;

namespace WordPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = "abba";
            var s = "dog cat cat dog";
            Console.WriteLine(WordPattern(pattern, s)); //Expected: true
        }

        //The method then initializes an empty dictionary called d which will be used to store the mappings between
        //characters in patter and words in tokens.

        //It then iterates through the characters in pattern using a for loop. For each character, it first checks if the character
        //exists as a key in d. If it does, then it checks if the value mapped to that key in d is equal to the corresponding word
        //in tokens. If they are not equal, it returns false. If the character does not exist in d as a key, then it checks if any of
        //the values in d are equal to the corresponding word in tokens. If any are equal, then it returns false, as there can be no
        //duplicate values in the dictionary. If the character does not exist in d and none of the values in d are equal to the corresponding
        //word in tokens, it adds the character as a key and the corresponding word in tokens as the value to d.

        //Finally, after the for loop has completed, it returns true as the pattern follows the same pattern as s.
        
        private static bool WordPattern(string pattern, string s) {
            string[] tokens = s.Split().ToArray();
            if(pattern.Length != tokens.Length) return false;
        
            Dictionary<char, string> d = new Dictionary<char, string>();
            for(int i = 0; i < pattern.Length; i++)
            {
                if(d.ContainsKey(pattern[i]))
                {
                    if(d[pattern[i]] != tokens[i]) return false;
                }
                else 
                {
                    if(d.Values.Any(x => x == tokens[i])) return false;
                    d.Add(pattern[i], tokens[i]);
                }
            }
        
            return true;
        }
    }
}