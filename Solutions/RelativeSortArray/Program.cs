using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace RelativeSortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 };
            int[] arr2 = new int[] { 2, 1, 4, 3, 9, 6 };
            
            Console.WriteLine(string.Join(",", RelativeSortArray(arr1, arr2)));
            //Expected: [2,2,2,1,4,3,3,9,6,7,19]
        }
        
        public static int[] RelativeSortArray(int[] arr1, int[] arr2) {
            Dictionary<int, int> d = new Dictionary<int, int>();
            HashSet<int> hs = new HashSet<int>(arr2);
            List<int> l = new List<int>();
        
            foreach(var x in arr1){
                if(hs.Contains(x)){
                    if(d.ContainsKey(x) == false) d.Add(x, 0);
                    d[x]++;
                }
                else l.Add(x);
            }
        
            List<int> ans = new List<int>();
            foreach(var x in arr2){
                ans.AddRange(Enumerable.Repeat(x, d[x]));
            }
        
            ans.AddRange(l.OrderBy(x => x));
            return ans.ToArray();
        }
    }
}