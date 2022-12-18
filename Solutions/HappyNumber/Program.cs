using System;
using System.Collections.Generic;

namespace HappyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 7;
            Console.WriteLine(IsHappy(n)); //Expected: true
        }

        //The method uses a HashSet object to keep track of the numbers that have been generated during
        //the sequence of operations. This is necessary to detect if the sequence becomes infinite,
        //in which case the number is not a happy number.
        
        //Inside the loop, the method checks if the current value of n is already in the HashSet.
        //If it is, the method returns false because this indicates that the sequence has become
        //infinite and n is not a happy number.
        
        //If n is not in the HashSet, the method adds it to the HashSet and then begins the process
        //of replacing n with the sum of the squares of its digits. It declares a new variable
        //initialized to 0, and enters a loop that continues until n is equal to 0.
        
        //Inside the loop, the method takes the remainder of n divided by 10, which is the rightmost
        //digit of n, and adds the square of this digit to newNum. It then divides n by 10 to remove the rightmost digit.
        
        //After the inner loop finishes, the method assigns the value of newNum to n and goes back to the beginning of the outer loop.
        
        //If the outer loop finishes and n is equal to 1, it means that the sequence of operations terminated
        //successfully and the method returns true, indicating that n is a happy number.
        
        private static bool IsHappy(int n) {
            HashSet<int> hs = new HashSet<int>();
        
            while(n != 1)
            {
                if(hs.Contains(n)) return false;
                hs.Add(n);
            
                int newNum = 0;
                while(n > 0)
                {
                    newNum += (int)Math.Pow(n%10, 2);
                    n/=10;
                }
            
                n = newNum;
            }
        
            return true;
        }
    }
}