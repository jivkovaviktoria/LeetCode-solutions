using System;

namespace TotalDistanceTraveled
{
    class Program
    {
        static void Main(string[] args)
        {
            int mainTank = 5, additionalTank = 10;
            Console.WriteLine(DistanceTraveled(mainTank, additionalTank));
            //Expected: 60
        }
        
        public static int DistanceTraveled(int mainTank, int additionalTank) {
            int ans = 0;
            while(mainTank >= 5 && additionalTank > 0){
                ans += 50;
                mainTank -= 5;
                mainTank++;
                additionalTank--;
            }
        
            while(mainTank-- > 0)
                ans+=10;
        
            return ans;
        }
    }
}