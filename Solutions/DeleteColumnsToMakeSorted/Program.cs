using System;

namespace DeleteColumnsToMakeSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new string[] { "cba", "daf", "ghi" };
            Console.WriteLine(MinDeletionSize(strs)); //Expected: 1
        }
        
        //The method then has a loop that goes through each column of the strings. For each column, it has another loop
        //that goes through each string and compares it to the string before it. If the character in the current string
        //is "less" than the character in the previous string (as determined by the comparison operator <) at the current
        //column, the method increments "res" by 1 and breaks out of the inner loop. If the loop goes through all of the
        //strings and no string has a character that is "less" than the character in the string before it, the method goes
        //to the next column.

        //Finally, the method returns the value of "res", which is the number of columns that need to be deleted to make the
        //list of strings lexicographically sorted.
        
        public static int MinDeletionSize(string[] strs) {
            int wordLength =strs[0].Length;
            int res = 0;

            for (int i = 0; i < wordLength; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] < strs[j - 1][i])
                    {
                        res++;
                        break;
                    }
                }
            }
            return res;
        }
    }
}