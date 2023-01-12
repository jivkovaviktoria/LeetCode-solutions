using System;
using System.Linq;

namespace NumberOfLinesToWriteString
{
    class Program
    {
        static void Main(string[] args)
        {
	        int[] widths = new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
	        string s = "abcdefghijklmnopqrstuvwxyz";

	        Console.WriteLine(NumberOfLines(widths, s)); //Expected: [3,60]
        }
        
        public static int[] NumberOfLines(int[] widths, string s) {
	        var letters = s.Select(x => widths[x - 'a']);
                
        	int lines = 1;
            int currLine = 0;
        	foreach(var letter in letters)
        	{
        		if(currLine + letter > 100)
        		{
        			lines++;
        			currLine = letter;
        		}
        		else currLine += letter;
        	}
                
        	
                return new[] {lines, currLine}; 
        }
    }
}