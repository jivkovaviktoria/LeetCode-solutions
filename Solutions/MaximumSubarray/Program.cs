using System;

namespace MaximumSubarray
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine(MaxSubArray(nums)); //Expected: 6
        }

        //The algorithm begins by initializing a variable sum to 0 and a variable maxSum to the first element
        //in the array. It then iterates through the array, adding each element to sum and comparing the value
        //of sum to the current element. If the current element is greater than sum, sum is set to the value
        //of the current element. Finally, the algorithm compares sum to maxSum and updates maxSum if sum is larger.
        //When the loop ends, maxSum will contain the maximum sum of a contiguous subarray within the input array.
        
        private static int MaxSubArray(int[] nums) {
        
            int sum = 0;
            int maxSum = nums[0];

            for(int i=0; i<nums.Length; i++)
            {
                sum += nums[i];
                if (nums[i] > sum) sum = nums[i];
                if (sum > maxSum) maxSum = sum; 
            }
	    
            return maxSum;
        }
    }
}