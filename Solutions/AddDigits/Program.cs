using System;

namespace AddDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 38;
            Console.WriteLine(AddDigits(num)); //Expected: 2
        }
        
        public static int AddDigits(int num) {
            int n = num;
        
            while(n > 9){
                int number = n;
                int x = 0;
                
                while(number > 0){
                    x += number%10;
                    number/=10;
                }
            
                n = x;
            }
        
            return n;
        
        }
    }
}