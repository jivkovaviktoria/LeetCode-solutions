using System;
using System.Collections.Generic;

namespace ExcelSheetColumnNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string columnTitle = "A";
            string columnTitle2 = "ZY";

            Console.WriteLine(TitleToNumber(columnTitle)); //Expected: 1
            Console.WriteLine(TitleToNumber(columnTitle2)); //Expected: 701
        }
        
        public static int TitleToNumber(string columnTitle) {
            Dictionary<char,int> dict = new Dictionary<char,int>();
        
            for(char c = 'A'; c <= 'Z'; c++){
                dict.Add(c, c - 'A' + 1);
            }
        
            int res = dict[columnTitle[0]];
            for(int i = 1; i <columnTitle.Length; i++) {
                res = (res * 26) + dict[columnTitle[i]];
            }
            return res;
        }
    }
}