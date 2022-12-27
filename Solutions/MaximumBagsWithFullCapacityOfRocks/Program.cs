using System;

namespace MaximumBagsWithFullCapacityOfRocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] capacity = new int[] { 2, 3, 4, 5 };
            int[] rocks = new int[] { 1, 2, 4, 4};
            int additionalRocks = 2;

            Console.WriteLine(MaximumBags(capacity, rocks, additionalRocks)); //Expected: 3
        }
        

        //This method appears to find the maximum number of bags that can be filled with a given number of additional rocks.
        //It does this by calculating the difference between the capacity of each bag and the number of rocks it already
        //contains (stored in the rocks array), and storing these values in the rocksNeeded array. It then sorts this array
        //in ascending order and iteratively subtracts the values from additionalRocks, incrementing a count each time.
        //If additionalRocks becomes negative at any point, the loop breaks and the count is returned as the result.
        //This count represents the maximum number of bags that can be filled with the given number of additional rocks.
        
        private static int MaximumBags(int[] capacity, int[] rocks, int additionalRocks) {
            var rocksNeeded = new int[capacity.Length];
            for(int i = 0; i < capacity.Length; i++)
                rocksNeeded[i] = capacity[i] - rocks[i];
        
            Array.Sort(rocksNeeded);
        
            int count = 0;
            foreach(var x in rocksNeeded){
                additionalRocks -= x;
                if(additionalRocks < 0) break;
                count++;
            }
        
            return count;
        }
    }
}