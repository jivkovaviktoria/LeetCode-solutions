using System;
using System.Text;

namespace CheckIfWordEqualsSummationOfTwoWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = "acb", secondWord = "cba", targetWord = "cdb";
            Console.WriteLine(IsSumEqual(firstWord, secondWord, targetWord)); //Expected: true
        }
        
        public static bool IsSumEqual(string firstWord, string secondWord, string targetWord) {
            return GetValue(firstWord) + GetValue(secondWord) == GetValue(targetWord);
        
            int GetValue(string word){
                StringBuilder sb = new StringBuilder();
                for(int i = 0; i < word.Length; i++){
                    sb.Append(word[i] - 'a');
                }
                return int.Parse(sb.ToString());
            }
        }
    }
}