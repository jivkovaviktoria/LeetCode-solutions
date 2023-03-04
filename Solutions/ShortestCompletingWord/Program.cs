using System;
using System.Collections.Generic;

namespace ShortestCompletingWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string licensePlate = "1s3 PSt";
            string[] words = new string[] { "step", "steps", "stripe", "stepple" };

            Console.WriteLine(ShortestCompletingWord(licensePlate, words));
            //Expected: "steps"
        }
        
        //We iterate through the license plate and add to dictionary every letter with its frequency count.
        //Then we iterate through each word in words and do the same. Then we check if the word contains each letter of the
        //license plate and if it has the same (or more) count of letters. It it doesnt we break and continue with the next
        //one, if it has we check if it is shorter than the previous completing word we found and if it is we set it to the
        //ans variable. 
        public static string ShortestCompletingWord(string licensePlate, string[] words) {
            Dictionary<char, int> lp = new Dictionary<char, int>();
        
            foreach(var c in licensePlate){
                if(Char.IsLetter(c)){
                    if(lp.ContainsKey(Char.ToLower(c)) == false) lp.Add(Char.ToLower(c), 0);
                    lp[Char.ToLower(c)]++;
                }
            }
        
            string ans = null;
            foreach(var word in words){
                Dictionary<char, int> w = new Dictionary<char, int>();
            
                foreach(var ch in word){
                    if(w.ContainsKey(Char.ToLower(ch)) == false) w.Add(Char.ToLower(ch), 0);
                    w[Char.ToLower(ch)]++;
                }
            
                bool isCompleting = true;
            
                foreach(var(key, value) in lp){
                    if(w.ContainsKey(key) == false){
                        isCompleting = false;
                        break;
                    }
                
                    if(w[key] < value){
                        isCompleting = false;
                        break;
                    }
                }
            
                if(isCompleting){
                    if(ans == null || ans.Length > word.Length) ans = word;
                }
            }
        
            return ans;
        }
    }
}