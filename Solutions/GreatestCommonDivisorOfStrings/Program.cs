using System;

namespace GreatestCommonDivisorOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "ABCABC", str2 = "ABC";
            Console.WriteLine(GcdOfStrings(str1, str2)); //Expected: ABC
        }
        
        public static string GcdOfStrings(string str1, string str2) {
        
            for(int i = Math.Min(str1.Length, str2.Length); i >= 1; i--){
                if(IsValid(i)) return str1.Substring(0, i);
            }
        
            return "";
        
            bool IsValid(int x){
                if(str1.Length % x == 0 && str2.Length % x == 0){
                    string s = str1.Substring(0, x);
                    return string.IsNullOrEmpty(str1.Replace(s, "")) && string.IsNullOrEmpty(str2.Replace(s, ""));
                }
            
                return false;
            }
        }
    }
}