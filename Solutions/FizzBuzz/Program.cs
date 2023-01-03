using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            Console.WriteLine(string.Join(",", FizzBuzz(n))); //Expected: ["1","2","Fizz"]
        }
        

        //The method first creates an empty list called "ans" that will eventually hold the answers. Then, it has a loop
        //that starts at 1 and goes up to n. For each number in this loop, the method checks if it is divisible by both
        //3 and 5. If it is, it adds "FizzBuzz" to the list "ans". If it is not, the method then checks if it is divisible
        //by 3. If it is, it adds "Fizz" to the list "ans". If it is not divisible by 3, it then checks if it is divisible
        //by 5. If it is, it adds "Buzz" to the list "ans". If it is not divisible by 3 or 5, it adds the number itself
        //to the list "ans" as a string. Finally, the method returns the list "ans".
        public static IList<string> FizzBuzz(int n) {
            List<string> ans = new List<string>();
            for(int i = 1; i <= n; i++)
            {
                if(i%3 == 0 && i%5 == 0) ans.Add("FizzBuzz");
                else if(i%3==0) ans.Add("Fizz");
                else if(i%5 == 0) ans.Add("Buzz");
                else ans.Add(i.ToString());
            }
        
            return ans;
        }
    }
}