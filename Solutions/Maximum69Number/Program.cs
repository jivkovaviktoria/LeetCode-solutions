using System;
using System.Linq;

namespace Maximum69Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 9669;
            Console.WriteLine(Maximum69Number(num)); //Expected: 9969
        }

        //We convert the num to string and then to char array so we can loop through it
        //If the current char is 6, we replace it with a 9 and break the loop
        //Otherwise the loop continues iterating through the digits. This ensured
        //that only the leftmost digit 6 is replaced, if any.
        //Finally we convert the char array to string and parse it to int
        private static int Maximum69Number (int num) {

            char[] res = num.ToString().ToArray();
        
            for(int i = 0; i < res.Length; i++)
            {
                if(res[i] == '6')
                {
                    res[i] = '9';
                    break;
                }
            }
        
            return int.Parse(new string(res));
        }
    }
}