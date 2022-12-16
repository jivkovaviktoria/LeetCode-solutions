using System;

namespace SubstractTheProductAndSumOfDigitsOfAnInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 234;
            Console.WriteLine(SubtractProductAndSum(n)); //Expected: 15
        }

        //We have two variables - product and sum, which are used to keep track of the product and sum of the digits
        //In num we keep the input number
        //We loop until the num reaches zero
        //In the loop we calculate the product by multiplying the last digit with the current product
        //and the sum by adding the last digit to the sum
        //(We use modulo operator % to get the last digit and then we divide the number by 10 to remove it)
        //then we return the difference between the product and the sum
        private static int SubtractProductAndSum(int n) 
        {
            int product = 1;
            int sum = 0;
        
            int num = n;
            while(num > 0)
            {   
                product*=num%10;
                sum+=num%10;
                num/=10;
            }
        
            return product - sum;
        }
    }
}