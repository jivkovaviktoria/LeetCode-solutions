using System;
using System.Collections.Generic;

namespace NumberOfRectanglesThatCanFormTheLargestSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] rectangles = new int[][]
            {
                new int[] { 5, 8 },
                new int[] { 3, 9 },
                new int[] { 5, 12 },
                new int[] { 16, 5 }
            };

            Console.WriteLine(CountGoodRectangles(rectangles)); //Expected: 3
        }
        
        public static int CountGoodRectangles(int[][] rectangles) {
            Dictionary<int, int> d = new Dictionary<int, int>();
            int max = -1;
        
            for(int i = 0; i < rectangles.Length; i++){
                var side = Math.Min(rectangles[i][0], rectangles[i][1]);
                if(d.ContainsKey(side) == false) d.Add(side, 0);
                d[side]++;
            
                if(side > max) max = side;
            }
        
            return d[max];
        
        }
    }
}