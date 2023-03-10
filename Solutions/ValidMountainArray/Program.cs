using System;

namespace ValidMountainArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 3, 2, 1 };
            Console.WriteLine(ValidMountainArray(arr)); //Expected: true
        }
        
        public static bool ValidMountainArray(int[] arr) {
            if(arr.Length < 3 || (arr[1] > arr[0]) == false) return false;
        
            bool isDecreasing = false;
        
            for(int i = 1; i < arr.Length; i++){
                if((arr[i] == arr[i-1]) || (isDecreasing && arr[i] > arr[i-1])) return false;
                if(arr[i] < arr[i-1]) isDecreasing = true;
            }
        
            return isDecreasing;
        }
    }
}