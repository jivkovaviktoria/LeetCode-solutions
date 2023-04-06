using System;

namespace LongestUncommonSubsequenceI
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "aba", b = "cdc";
            Console.WriteLine(FindLUSlength(a, b)); //Expected: 3
        }
        
        //If len(X) > len(Y) then X can't be a subsequence of Y. In this case the longer string is by definition the longest uncommon subsequence.
        //If len(X) == len(Y) but X != Y then then X can't be a subsequence of Y. In this case both strings are "uncommon subsequences" in respect to each other.
        //If X == Y then the longest uncommon subsequence doesn't exist.
        public static int FindLUSlength(string a, string b) {
            if(a == b) return -1;
            return Math.Max(a.Length, b.Length);
        }
    }
}