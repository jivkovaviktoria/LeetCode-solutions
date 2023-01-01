using System;

namespace PartitionStringIntoSubstringsWithValuesAtMostK
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "238182";
            int k = 5;
            Console.WriteLine(MinimumPartition(s, k));
        }
        public static int MinimumPartition(string s, int k) {
            int ans = 0;

            bool isLast = false;
            for(int i = 0; i < s.Length;i++)
            {
                long digit = s[i] - '0';
                if (digit > k) return -1;
                int index = i+1;
            
                while(true)
                {
                    digit*=10;
                    if (index >= s.Length)
                    {
                        isLast = true;
                        break;
                    }
                    digit += s[index] - '0';

                    index++;
                    
                    if (digit > k)
                        break;
                }
            
                i = index-2;
                ans++;
                if (isLast) break;
            }
        
            return ans;
        }
    }
}