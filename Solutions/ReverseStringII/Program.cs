using System;
using System.Linq;

namespace ReverseStringII
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcdefg";
            int k = 2;
            Console.WriteLine(ReverseStr(s, k)); //Expected: "bacdfeg"
        }
        
        public static string ReverseStr(string s, int k) {
            return string.Concat(s
                .Take(k).Reverse()
                .Concat(s.Skip(k).Take(k))
                .Concat(s.Length > 2 * k
                    ? ReverseStr(s.Substring(2 * k), k)
                    : string.Empty
                )
            );
        }
    }
}