using System;

namespace MaxIncreaseToKeepCitySkyline
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[][] { new int[] { 3, 0, 8, 4 }, new int[] { 2, 4, 5, 7 }, new int[] { 9, 2, 6, 3 }, new int[] { 0, 3, 1, 0 } };
            Console.WriteLine(MaxIncreaseKeepingSkyline(grid));
            //Expected: 35
        }
        
        public static int MaxIncreaseKeepingSkyline(int[][] grid) {
            int max = 0;
            int[] maxRow = new int[grid.Length], maxCol = new int[grid.Length];
        
            for(int i = 0; i < grid.Length; i++){
                for(int j = 0; j < grid[i].Length; j++){
                    maxRow[i] = Math.Max(maxRow[i], grid[i][j]);
                    maxCol[j] = Math.Max(maxCol[j], grid[i][j]);
                }
            }
        
            for(int i = 0; i < grid.Length; i++){
                for(int j = 0; j < grid[i].Length; j++)
                    max += Math.Min(maxRow[i], maxCol[j]) - grid[i][j];
            }
        
            return max;
        }
    }
}