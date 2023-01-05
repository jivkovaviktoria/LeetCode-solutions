using System;
using System.Text;

namespace ReversePrefixOfWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "abcdefd";
            char ch = 'd';
            Console.WriteLine(ReversePrefix(word, ch)); //Expected: dcbaefd
        }
        
        public static string ReversePrefix(string word, char ch) {
            int index = word.IndexOf(ch);
        
            StringBuilder sb = new StringBuilder();
            for(int i = index; i >= 0; i--)
                sb.Append(word[i]);
        
            for(int i = index+1; i < word.Length; i++)
                sb.Append(word[i]);
        
            return sb.ToString();
        }
    }
}