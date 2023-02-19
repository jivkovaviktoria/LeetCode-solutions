using System;

namespace TrappingRainWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] height = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            Console.WriteLine(Trap(height)); //Expected: 6
        }
        
        public static int Trap(int[] height) {
            if(height is null || height.Length == 0) return 0;
        
            int index = 0, n = height.Length-1;
            int leftMax = 0, rightMax = 0;
            int ans = 0;
        
            while(index <= n){
                if(height[index] < height[n]){
                    if(height[index] < leftMax) ans += leftMax - height[index];
                    else leftMax = height[index];
                    index++;
                }
                else{
                    if(height[n] < rightMax) ans += rightMax - height[n];
                    else rightMax = height[n];
                    n--;
                }
            }
        
            return ans;
        }
    }
}