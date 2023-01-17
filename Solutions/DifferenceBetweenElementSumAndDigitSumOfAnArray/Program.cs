using System;

namespace DifferenceBetweenElementSumAndDigitSumOfAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 15, 6, 3 };
            Console.WriteLine(DifferenceOfSum(nums)); //Expected: 9

            int[] nums2 = new int[] { 1, 2, 3, 4 };
            Console.WriteLine(DifferenceOfSum(nums2)); //Expected: 0
        }
        
        //We iterate through the array and add each element to a 'sum' variable, then break down each element
        //into its digits, adding each digit to a 'dSum' variable, and returning the absolute difference between 'sum' and
        //'dSum'.
        public static int DifferenceOfSum(int[] nums) {
            int sum = 0;
            int dSum = 0;
        
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            
                int num = nums[i];
                while(num > 0)
                {
                    dSum+=num%10;
                    num/=10;
                }
            }
        
            return Math.Abs(sum-dSum);
        }
    }
}