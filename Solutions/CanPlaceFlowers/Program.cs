using System;

namespace CanPlaceFlowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] flowerbed = new int[] { 1, 0, 0, 0, 1 };
            int n = 1;
            Console.WriteLine(CanPlaceFlowers(flowerbed, n)); //Expected: true
        }
        
        public static bool CanPlaceFlowers(int[] flowerbed, int n) {
            for(int i = 0; i < flowerbed.Length; i++){
                if(flowerbed[i] == 0){
                    int prev = (i == 0) ? 0 : flowerbed[i-1];
                    int next = (i == flowerbed.Length-1) ? 0 : flowerbed[i+1];
                
                    if(prev == 0 && next == 0){
                        flowerbed[i] = 1;
                        n--;
                    }
                }
            
                if(n == 0) return true;
            }
        
            return n <= 0;
        }
    }
}