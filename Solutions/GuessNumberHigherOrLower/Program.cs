using System;

namespace GuessNumberHigherOrLower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GuessNumber(10)); //Expected: 6
        }
        
        public static int GuessNumber(int n)
        {
            int pick = 6; // Picked number
            
            int s = 0, e = n;
        
            while(s <= e){
                int mid = s + (e - s)/2;
            
                if(guess(mid) == -1) e = mid - 1;
                else if(guess(mid) == 1) s = mid + 1;
                else return mid;
            }
        
            return -1;

            int guess(int num)
            {
                if (num > pick) return -1;
                else if (num < pick) return 1;
                return 0;
            }
        }
    }
}