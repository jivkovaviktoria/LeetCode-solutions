using System;

namespace SignOfTheProductOfAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 1, 5, 0, 2, -3 };
            Console.WriteLine(ArraySign(input)); //Expected: 0
        }

        private static int ArraySign(int[] nums)
        {
            int p = 1; //This variable will be used to store the sign of the product of the elements in the array
            
            for(int i = 0; i < nums.Length; i++) //iterate over the array
            {
                //checks whether the current element is zero.
                //If it is, the method returns 0 immediately, because the product of any set of numbers that includes a zero is always zero.
                if (nums[i] == 0) return 0;
                
                //If the current element is not zero, the method checks whether it is negative.
                //If it is, the method multiplies p by -1, which flips the sign of p from positive to negative or vice versa.
                if (nums[i] < 0) p *= -1;
            }
            
            return p; //we return the value of `p` which represents the sign of the product of the elements in the array
        }
    }
}