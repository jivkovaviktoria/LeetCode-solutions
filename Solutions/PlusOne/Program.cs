using System;

namespace PlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var digits = new int[] { 1, 2, 3 };
            Console.WriteLine(string.Join(",", PlusOne(digits)));  //Expected: [1,2,4]
        }

        //We start from the last digit and if it is smaller than 9
        //we increment it and return the result
        //If it is 9 we set it to zero and go to the next digit
        //If there is no digit after it we make new array with the length of the digits array +1
        //snd set the first digit to 1 (Example - 99, it becomes 00.. we make new array with length 3 and set 
        //the first digit to 1 => 100;
        private static int[] PlusOne(int[] digits) {
            for(int i=digits.Length-1;i>=0;i--)
            {
                if(digits[i]<9)
                {
                    digits[i]++;
                    return digits; 
                }
                digits[i]=0;
            } 
        
            int[] result=new int[digits.Length+1];
            result[0]=1;
            return result;
        }
    }
}