using System;

namespace DIstringMatch
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "IDID";
            Console.WriteLine(string.Join(",", DiStringMatch(s)));
            //Expected: [0,4,1,3,2];
        }
        
        public static int[] DiStringMatch(string s) {
            int[] ans = new int[s.Length + 1];
        
            int l = 0, r = s.Length;
            for(int i = 0; i < s.Length; i++){
                if(s[i] == 'I') ans[i] = l++;
                else ans[i] = r--;
            }
        
            ans[s.Length] = l;
            return ans;
        }
    }
}