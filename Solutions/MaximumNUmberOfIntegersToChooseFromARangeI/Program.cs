using System;
using System.Linq;

namespace MaximumNUmberOfIntegersToChooseFromARangeI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] banned = new int[] { 1, 6, 5 };
            int n = 5, maxSum = 6;
            Console.WriteLine(MaxCount(banned, n, maxSum)); //Expected: 2
        }
        
        public static int MaxCount(int[] banned, int n, int maxSum) {
            int ans = 0;
            int currentSum = 0;
            for(int i = 1; i <= n; i++){
                if(banned.Contains(i) == false && currentSum+i <= maxSum){
                    currentSum+=i;
                    ans++;
                }
            }
            
            return ans;
        }
    }
}