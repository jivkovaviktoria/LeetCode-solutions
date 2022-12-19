using System;

namespace CheckIfItIsAStraightLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var coordinates = new int[][]
            {
                new int[] { 1, 2 },
                new int[] { 2, 3 },
                new int[] { 3, 4 },
                new int[] { 4, 5 },
                new int[] { 5, 6 },
                new int[] { 6, 7 }
            };
            Console.WriteLine(CheckStraightLine(coordinates)); //Expected: true
        }
        
        //This method receives an array of coordinates as input and checks whether these coordinates form a straight line or not.
        //It does this by iterating over the coordinates and checking the slope between the first and each subsequent coordinate.
        //If all the slopes are the same, then it returns true, indicating that the coordinates form a straight line.
        //If any of the slopes is different, then it returns false, indicating that the coordinates do not form a straight line.
        
        //The method first checks if the x-coordinate of the first and second point is the same.
        //If it is, then it checks whether all the remaining x-coordinates are the same or not.
        //If all the x-coordinates are the same, then the method returns true,
        //because all the points lie on a vertical line. If any of the x-coordinates is different,
        //then the method returns false, because the points do not form a straight line.
        
        //Note: slope = (y2 - y1) / (x2 - x1)
        
        //Then, the method iterates over the remaining coordinates and calculates the slope between
        //the first coordinate and each subsequent coordinate. If any of these slopes is different
        //from the slope between the first and second point, then the method returns false,
        //indicating that the points do not form a straight line. If all the slopes are the same,
        //then the method returns true, indicating that the points form a straight line.

        private static bool CheckStraightLine(int[][] coordinates)
        {
            if (coordinates[1][0] == coordinates[0][0])
            {
                for (int i = 2; i < coordinates.Length; i++) {
                    if (coordinates[i][0] != coordinates[0][0]) return false;
                }
            
                return true;
            } 
            else
            {
                double slope = (coordinates[1][1] - coordinates[0][1]) / (double)(coordinates[1][0] - coordinates[0][0]);
                
                for (int i = 2; i < coordinates.Length; i++)
                {
                    double currentSlope = (coordinates[i][1] - coordinates[0][1]) / (double)(coordinates[i][0] - coordinates[0][0]);
            
                    if (currentSlope != slope) return false;
                }
        
                return true;
            }
        }
    }
}