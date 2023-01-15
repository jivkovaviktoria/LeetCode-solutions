using System;
using System.Collections.Generic;

namespace ElementAppearingMoreThan25PercentsInSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 2, 6, 6, 6, 6, 7, 10 };
            Console.WriteLine(FindSpecialInteger(arr)); //Expected: 6

            int[] arr2 = new int[] { 1, 1 };
            Console.WriteLine(FindSpecialInteger(arr2)); //Expected: 1
        }
        
        public static int FindSpecialInteger(int[] arr) {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if(map.ContainsKey(arr[i]) == false) map.Add(arr[i], 0);
                map[arr[i]]++;
            }
        
            foreach(var (key, val) in map)
                if(val > (arr.Length/4)) return key;
        
            return -1;
        }
    }
}