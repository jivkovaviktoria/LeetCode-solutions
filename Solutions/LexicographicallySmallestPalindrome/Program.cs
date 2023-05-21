using System;

namespace LexicographicallySmallestPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "seven";
            Console.WriteLine(MakeSmallestPalindrome(s)); //Expected: neven
        }
        
        public static string MakeSmallestPalindrome(string s) {
            char[] sArr = s.ToCharArray();
            for(int i = 0; i < s.Length/2; i++){
                if(sArr[i] <= sArr[s.Length-1-i]) sArr[s.Length-1-i] = sArr[i];
                else sArr[i] = sArr[s.Length-1-i];
            }
        
            return new string(sArr);
        }
    }
}