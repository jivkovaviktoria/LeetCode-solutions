using System;

namespace ClimbingStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            Console.WriteLine(ClimbStairs(n)); //Expected: 3
        }
        
        //Explanation:
        //We know that we can only take 2 steps which means we could have only come from the previous step,
        //or 2 steps before it and because of that every next step will be equal to x[i-1] + x[i-2]

        private static int ClimbStairs(int n) {

            if(n < 3) return n;
            int[] steps = new int[n+1];
            steps[0] = 1;
            steps[1] = 1;

            for(int i = 2; i <= n; i++) 
                steps[i] = steps[i-1] + steps[i-2];

            return steps[n];
        
        }
    }
}