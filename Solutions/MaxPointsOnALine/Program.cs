using System;
using System.Collections.Generic;

namespace MaxPointsOnALine
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] points = new int[6][]
            {
                new int[] { 1, 2 },
                new int[] { 3, 2 },
                new int[] { 5, 3 },
                new int[] { 4, 1 },
                new int[] { 2, 3 },
                new int[] { 1, 4 }
            };

            Console.WriteLine(MaxPoints(points)); //Expected: 4
        }
        
        //This method calculates the maximum number of points that lie on the same line. It does this by iterating through
        //each point in the array and calculating the slope of the line formed by this point and every other point. It then
        //stores the number of points that have the same slope in a dictionary, and updates the maximum number of points with
        //the same slope found so far. Finally, it returns the maximum number of points found. The method also has a helper
        //function that calculates the slope of a line given two points.
        public static int MaxPoints(int[][] points)
        {
            int ans = 0;
            for (int i = 0; i < points.Length; i++)
            {
                Dictionary<double, int> dic = new Dictionary<double, int>();
                int max = 0;
                for (int j = i + 1; j < points.Length; j++)
                {
                    double slope = GetSlope(points[i], points[j]);
                    if (!dic.ContainsKey(slope)) dic.Add(slope, 0);

                    dic[slope]++;
                    max = Math.Max(max, dic[slope]);
                }

                ans = Math.Max(ans, max + 1);
            }

            return ans;

            double GetSlope(int[] point1, int[] point2)
            {
                double dx = point2[0] - point1[0];
                double dy = point2[1] - point1[1];

                if (dx == 0) return Double.MaxValue;

                return dy / dx;
            }
        }
    }
}