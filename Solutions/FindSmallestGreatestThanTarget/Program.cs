using System;

namespace FindSmallestGreatestThanTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = new char[] { 'c', 'f', 'j' };
            char target = 'a';

            Console.WriteLine(NextGreatestLetter(letters, target)); //Expected: c
        }
        
        public static char NextGreatestLetter(char[] letters, char target) {
            foreach(var c in letters){
                if(c > target) return c;
            }

            return letters[0];
        }
    }
}