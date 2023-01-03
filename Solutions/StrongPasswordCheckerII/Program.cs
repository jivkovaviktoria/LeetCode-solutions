using System;
using System.Collections.Generic;

namespace StrongPasswordCheckerII
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "IloveLe3tcode!";
            Console.WriteLine(StrongPasswordCheckerII(password)); //Expected: true
        }
        
        public static bool StrongPasswordCheckerII(string password) {
            HashSet<char> hs = new HashSet<char>() {'!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+'};
        
            if(password.Length < 8) return false;
        
            bool lowerCase = false;
            bool upperCase = false;
            bool hasDigit = false;
            bool hasSpCh = false;
        
            for(int i = 0; i < password.Length; i++)
            {
                if( i > 0 && password[i] == password[i-1]) return false;
                if(Char.IsDigit(password[i])) hasDigit = true;
                if(hs.Contains(password[i])) hasSpCh = true;
                if(Char.IsLower(password[i])) lowerCase = true;
                if(Char.IsUpper(password[i])) upperCase = true;
            }
        
            if((lowerCase && upperCase) && hasDigit && hasSpCh) return true;
            return false;
        }
    }
}