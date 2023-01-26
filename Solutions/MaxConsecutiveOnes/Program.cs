using System;

namespace MaxConsecutiveOnes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1,1,0,1,1,1};
            Console.WriteLine(FindMaxConsecutiveOnes(nums)); //Expected: 3
        }
        
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int max = 0;
            int current = 0;
        
            for(int i = 0; i < nums.Length; i++){
                if(nums[i] == 1){
                    current++;
                    if(max < current) max = current;
                }
                else{
                    current = 0;
                }
            }
        
            return max;
        }
    }
}