using System;

namespace LongestContiguousSegmentsOfOnesThanZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "1101";
            Console.WriteLine(CheckZeroOnes(s)); //Expected: true
        }
        
        public static bool CheckZeroOnes(string s) {
            int maxOnes = 0, maxZeros = 0, currentOnes = 0, currentZeros = 0;
        
            for(int i = 0; i < s.Length; i++){
                if(s[i] == '1'){
                    currentZeros = 0;
                    currentOnes++;
                    if(maxOnes < currentOnes) maxOnes = currentOnes;
                }
                else{
                    currentOnes = 0;
                    currentZeros++;
                    if(maxZeros < currentZeros) maxZeros = currentZeros;
                }
            }
        
            return maxOnes > maxZeros;
        }
    }
}