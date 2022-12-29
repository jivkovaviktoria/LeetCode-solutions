using System;

namespace PercentageOfLetterInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abca";
            char letter = 'a';
            Console.WriteLine(PercentageLetter(s, letter)); //Expected: 50
        }
        
        //The method takes in a string called s and a character called letter as input.
        //It initializes a count variable to zero, which will be used to keep track of the number of occurrences of letter
        //in s. It then iterates through the characters in s using a for loop. For each character in the string, it checks
        //if the character is equal to letter. If it is, it increments the count variable. After the loop has completed,
        //it calculates the percentage of letter occurrences in s by multiplying the count by 100 and dividing it by the
        //length of s. Finally, it returns the calculated percentage.

        private static int PercentageLetter(string s, char letter) {
            int count = 0;
            for(int i = 0; i < s.Length; i++)
                if(s[i] == letter) count++;
        
            return count*100/s.Length;
        }
    }
}