using System;
using System.Threading.Channels;

namespace MinimumNumberOfArrowsToBurstBalloons
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] points = new int[4][]
            {
                new int[] { 10, 16 },
                new int[] { 2, 8 },
                new int[] { 1, 6 },
                new int[] { 7, 12 }
            };

            Console.WriteLine(FindMinArrowShots(points)); //Expected: 2
        }
        
        public static int FindMinArrowShots(int[][] points) {
            if(points.Length == 0) return 0;
            int ans = 1;
        
            Array.Sort(points, (x,y) => x[1] >= y[1] ? 1 : -1);
        
            int arrowPos = points[0][1];
        
            for(int i=1; i<points.Length; i++){
                if(points[i][0] <= arrowPos) continue;
                ans++;
                arrowPos = points[i][1];
            }
        
            return ans;
        }
    }
}