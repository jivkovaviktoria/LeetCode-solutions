using System;
using System.Collections.Generic;
using System.Linq;

namespace KthDistinctStringInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] { "d", "b", "c", "b", "c", "a" };
            int k = 2;

            Console.WriteLine(KthDistinct(arr, k)); //Expected: "a"
        }
        
        /// <summary>
        /// This method returns the kth distinct string present in arr
        /// </summary>
        /// <param name="arr">Array of strings</param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static string KthDistinct(string[] arr, int k) {
            Dictionary<string, (int count, int index)> d = new Dictionary<string, (int count, int index)>();
            for(int i = 0; i < arr.Length; i++){
                if(d.ContainsKey(arr[i]) == false) d.Add(arr[i], (0, i));
                d[arr[i]] = (d[arr[i]].count + 1, i);
            }
        
            List<(string, int, int)> distinctStrings = 
                d.Where(x => x.Value.count == 1)
                    .Select(x => (x.Key, x.Value.count, x.Value.index))
                    .OrderBy(x => x.Item3)
                    .ToList();

            if (distinctStrings.Count < k) return "";
            return distinctStrings[k - 1].Item1;
        }
    }
}