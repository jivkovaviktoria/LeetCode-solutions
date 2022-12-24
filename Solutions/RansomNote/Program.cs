using System;
using System.Collections.Generic;

namespace RansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            var ransomNote = "aa";
            var magazine = "aab";
            Console.WriteLine(CanConstruct(ransomNote, magazine)); //Expected: true
        }

        //We store the frequency of each char that apperas in `magazine`, like that
        //we keep track of the number of occurences of each character in `magazine`
        //Then we iterate through each char in `ransomNote` and check if the current 
        //char is in the `map`, if it's not we return false (because it's not possible
        //to construct the ransomNote from the magazine), then we check if the count
        //for that char is 0, that means there are no more occurrences of that char in the magazine
        //so we return false. If it is not 0, we decrease the count and continue. 
        //If we don't return false, we return true because we have succesfully chechked that all
        //of the characters in the `ransomNote` can be fount in `magazine`
        
        private static bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
                for(int i = 0; i < magazine.Length; i++)
                {
                    if(map.ContainsKey(magazine[i]) == false)
                        map.Add(magazine[i], 0);
                    map[magazine[i]]++;
                }
                
                for(int i = 0; i < ransomNote.Length; i++)
                {
                    if(map.ContainsKey(ransomNote[i]) == false) return false;
                    else if(map[ransomNote[i]] == 0) return false;
                    
                    map[ransomNote[i]]--;
                }
                
                return true;
            }
    }
}