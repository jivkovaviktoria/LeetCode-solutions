using System;

namespace ImplementMagicDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var magicDictionary = new MagicDictionary();
            magicDictionary.BuildDict(new string[] {"hello", "world", "leetcode"});

            // Expected: false
            var result1 = magicDictionary.Search("hello");
            
            // Expected: false
            var result2 = magicDictionary.Search("hell");

            // Expected: true
            var result3 =  magicDictionary.Search("hellp");

            Console.WriteLine($"{result1}, {result2}, {result3}");
        }
    }
}