using System;
using System.Collections.Generic;

namespace PascalsTriangleII
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 3;
            Console.WriteLine(string.Join(",", GetRow(row))); //Expected: [1,3,3,1]
        }
        
        public static IList<int> GetRow(int rowIndex) {
            List<List<int>> res = new List<List<int>>();

            for (int i = 0; i < rowIndex + 1; i++)
            {
                var rowList = new List<int>();
                res.Add(rowList);
                
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i) rowList.Add(1);
                    else rowList.Add(res[i - 1][j - 1] + res[i - 1][j]);
                }
            }
        
            return res[rowIndex];
        }
    }
}