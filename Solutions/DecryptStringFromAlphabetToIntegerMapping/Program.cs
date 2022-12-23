using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecryptStringFromAlphabetToIntegerMapping
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "10#11#12";
            Console.WriteLine(FreqAlphabets(input)); //Expected: "jkab"
        }
       
        //The method first initializes a dictionary map that maps integer values from 1 to 26
        //to the corresponding lowercase letters of the alphabet. It also initializes a StringBuilder
        //object ans to store the decoded version of the input string, and a stack s to store the characters
        //of the input string in reverse order.

        //The method then iterates through the characters in the input string, pushing each character onto the stack s.
        //After all the characters have been pushed onto the stack, the method begins a loop that continues until the
        //stack is empty.

        //In each iteration of the loop, the method pops the top character from the stack,
        //which is the current character being processed. If the current character is a '#', the method pops
        //the two characters preceding the '#' from the stack and combines them into a string.
        //It then converts this string to an integer and looks up the corresponding letter in the map dictionary,
        //adding it to the ans StringBuilder object.

        //If the current character is not a '#', the method converts it to an integer and looks up the corresponding
        //letter in the map dictionary, adding it to the ans StringBuilder object.

        //After the loop ends, the method converts the ans StringBuilder object to a string, reverses the string,
        //and returns it as the decoded version of the input string.
        
        private static string FreqAlphabets(string st) {
        
            Dictionary<int, char> map = new Dictionary<int, char>();
            StringBuilder ans = new StringBuilder();
            Stack<char> s = new Stack<char>();
            
            for (int i = 'a', j = 1; j <= 26; i++, j++)
                map.Add(j, (char)i);
            
            for (int i = 0; i < st.Length; i++)
                s.Push(st[i]);
            

            while (s.Count > 0)
            {
                var current = s.Pop();

                if (current == '#')
                {
                    char x2 = s.Pop();
                    char x1 = s.Pop();

                    string res = (x1 + x2).ToString();

                    int num = int.Parse(x1 + "" + x2);
                    ans.Append(map[num]);
                }
                else
                {
                    int num = int.Parse(current.ToString());
                    
                    ans.Append(map[num]);
                }
            }

            string result = ans.ToString();
            return string.Join("", result.Reverse());
        }
    }
}