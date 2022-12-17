using System;

namespace FindThenEarestPointThatHasTheSameXorYCoordinate
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = new int[][] { new int[] { 1, 2 }, new int[] { 3, 1 }, new int[] { 2, 4 }, new int[] { 2, 3 }, new int[] { 4, 4 } };
            int x = 3, y = 4;

            Console.WriteLine(NearestValidPoint(x, y, points)); //Expected:  2
        }

        //This method finds the nearest point from a given set of points `points` that has either the same `x` or `y` coordinate
        //as the given point (x, y). It does this by iterating through each point in `points` and calculating the distance between the given point
        //and the current point using the Manhattan distance formula `abs(points[i][0] - x) + abs(points[i][1] - y)`
        //If the distance is less than the current minimum distance, the index of the current point is saved as the result and the distance is updated.
        //If no valid point is found, the result is set to -1.
        
        private static int NearestValidPoint(int x, int y, int[][] points) 
        {
            int res = -1;
            int distance = Int32.MaxValue;
        
            for(int i = 0; i < points.Length; i++)
            {
                if(points[i][0] == x || points[i][1] == y)
                {
                    int currentDistance = Math.Abs(points[i][0] - x) + Math.Abs(points[i][1] - y);
                    if(currentDistance < distance) 
                    {
                        res = i;
                        distance = currentDistance;
                    }
                }
            }
        
            return res;
        }
    }
}