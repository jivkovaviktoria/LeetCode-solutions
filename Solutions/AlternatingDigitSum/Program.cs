using System;
using System.Collections.Generic;
using System.Linq;

namespace AlternatingDigitSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 521;
            Console.WriteLine(AlternateDigitSum(num)); //Expected: 4
        }
        
        public static int AlternateDigitSum(int n) {
            Stack<int> s = new Stack<int>();
        
            while(n > 0){
                s.Push(n%10);
                n/=10;
            }
        
            int idx = 0, ans = 0;
            while(s.Any()){
                if(idx%2 == 0) ans += s.Pop();
                else ans -= s.Pop();
                idx++;
            }
        
            return ans;
        }
    }
}