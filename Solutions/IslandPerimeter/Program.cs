using System;

namespace IslandPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[][]
            {
                new int[] { 0, 1, 0, 0 },
                new int[] { 1, 1, 1, 0 },
                new int[] { 0, 1, 0, 0 },
                new int[] { 1, 1, 0, 0 }
            };

            Console.WriteLine(IslandPerimeter(grid)); //Expected: 16
        }
        
        public static int IslandPerimeter(int[][] grid) {
            int ans = 0;
        
            int h = grid.Length;
        
            for (int i = 0; i < h; i++) {
                int w = grid[i].Length;
                for (int j = 0; j < w; j++) {
                    if (grid[i][j] == 1) {
                        if (i == 0 || grid[i-1][j] == 0) ans++;
                        if (i == h-1 || grid[i+1][j] == 0) ans++;
                        if (j == 0 || grid[i][j-1] == 0) ans++;
                        if (j == w - 1 || grid[i][j+1] == 0) ans++;
                    }
                }
            }
        
            return ans;
        }
    }
}