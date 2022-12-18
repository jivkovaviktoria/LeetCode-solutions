using System;

namespace CanMakeArithmeticProgression
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 3, 5, 1 };
            Console.WriteLine(CanMakeArithmeticProgression(input)); //Expected: true
        }

        //First we sort the array in ascending order.
        //Then iterate over the elements of the array, starting at the
        //first element and ending at the second-to-last element.
        //For each iteration, we check whether the difference between
        //the current element and the next element is equal to the difference
        //between the next element and the element after that.
        //If any of these differences are not equal, we return false,
        //because it is not possible to create an arithmetic progression with these elements.

        //If the method finishes iterating over the array without returning false,
        //it returns true, indicating that it is possible to create an arithmetic progression with the elements of the array.
        
        private static bool CanMakeArithmeticProgression(int[] arr)
        {
            Array.Sort(arr);
        
            for(int i = 0; i < arr.Length-2; i++)
            {
                if(arr[i+1] - arr[i] != arr[i+2] - arr[i+1]) return false;
            }
        
            return true;
        }
    }
}