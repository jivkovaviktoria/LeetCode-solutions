using System;
using System.Linq;

namespace MaximumValueOfAStringInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var strs = new string[] { "alic3", "bob", "3", "4", "00000" };
            Console.WriteLine(MaximumValue(strs)); //Expected: 5
        }

        //We loop through strs and check if the current string has digits, if it has -
        //his value will be his length. We check if his value is greater than the current
        //max value and if it is we set the max value to the current. If the current string
        //contains only digits we convert it to int and do the same with his int value.
        private static int MaximumValue(string [] strs)
        {
            int max = 0;
            for(int i = 0; i < strs.Length; i++)
            {
                if(strs[i].All(char.IsDigit) == false)
                {
                    if(max < strs[i].Length) max = strs[i].Length;
                }
                else
                {
                    if(max < int.Parse(strs[i])) max = int.Parse(strs[i]);
                }
            }
        
            return max;
        }
    }
}