using System;
using System.Text;

namespace ThousandSeparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1234;
            Console.WriteLine(ThousandSeparator(n)); //Expected: 1.234
        }
        
        public static string ThousandSeparator(int n) {
        
            string s = n.ToString(); 
            if(n <  1000 && n >= 0) return s; 
        
            StringBuilder sb = new StringBuilder();   
            int count = 0; 
        
            for(int i = s.Length-1; i >= 0; i--)
            {    
                if(count == 3)
                {
                    sb.Insert(0, '.');
                    count=0;
                }
            
                sb.Insert(0,s[i]); 
                count++; 
            }
        
            return sb.ToString(); 
        }
    }
}