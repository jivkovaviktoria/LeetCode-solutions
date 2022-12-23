using System;
using System.Collections.Generic;

namespace CellsInARangeOnAnExcelSheet
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "K1:L2";
            Console.WriteLine(string.Join(",", CellsInRange(s)));
            //Expected: ["K1","K2","L1","L2"]
        }
        
        //The method extracts the first and last columns and rows of the range from the input string,
        //and generates a list of all the cells in the range.

        private static IList<string> CellsInRange(string s) {
        
            char col1 = s[0], col2 = s[3];
            char row1 = s[1], row2 = s[4];
    
            List<string> res = new List<string>();
        
            for(char c = col1; c <= col2; c++)
            {
                for(char r = row1; r <= row2; r++)
                    res.Add(c.ToString() + r.ToString());
            }
        
            return res;
        }
    }
}