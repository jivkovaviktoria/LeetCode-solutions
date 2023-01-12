using System;
using System.Collections.Generic;

namespace NumberOfValidWordsInASentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence1 = "cat and  dog";
            string sentence2 = "!this  1-s b8d!";

            Console.WriteLine(CountValidWords(sentence1)); //Expected: 3
            Console.WriteLine(CountValidWords(sentence2)); //Expected: 0
        }
        
        public static int CountValidWords(string sentence) {
            var words = sentence.Split(' ');
            var count = 0; 
            var puncList = new HashSet<char> { '!', '.', ',' };
        
            foreach (var word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    if (IsValid(word, puncList))
                    {
                        count++;
                    }
                }
            }
        
            return count;
        }

        static bool IsValid(string word, HashSet<char> puncList)
        {
            bool isHyphen = false;
            for (int i = 0; i < word.Length; i++)
            {
                var ch = word[i];
                if (char.IsDigit(ch)) return false;
                if (char.IsLetter(ch)) continue;
                if (puncList.Contains(ch))
                {
                    if (i != word.Length - 1)
                        return false;
                }
                if (ch == '-')
                {
                    if (isHyphen || i == 0 || i == word.Length - 1 || !char.IsLetter(word[i - 1]) || !char.IsLetter(word[i + 1]))
                        return false;
                    isHyphen = true;
                }
            }
        
            return true;
        }
    }
}