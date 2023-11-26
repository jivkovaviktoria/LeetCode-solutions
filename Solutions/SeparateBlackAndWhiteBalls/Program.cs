using System;
using System.Runtime.CompilerServices;

namespace SeparateBlackAndWhiteBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "100";
            Console.WriteLine(MinimumSteps(s)); //Expected: 2
        }
        
        //We iterate through the string, counting steps for each '0' found based on its distance from the current position. 
        public static long MinimumSteps(string s) {
            long ans = 0;
        
            int ones = 0;        
            for(int i = 0; i < s.Length; i++){
                if(s[i] == '0') ans += ones;
                else if (s[i] == '1') ones++;
            }
        
            return ans;
        }
    }
}