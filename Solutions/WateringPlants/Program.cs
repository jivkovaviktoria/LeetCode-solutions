using System;

namespace WateringPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] plants = new int[] { 7,7,7,7,7,7,7};
            int c = 8;
            Console.WriteLine(WateringPlants(plants, c)); //Expected: 49
        }
        
        public static int WateringPlants(int[] plants, int capacity) {
            int steps = 1;
            if(plants[0] > capacity) return steps;
        
            int water = capacity - plants[0];
            for(int i = 0; i < plants.Length-1; i++)
            {
                if(plants[i+1] > water) 
                {
                    steps += 2*i+2;
                    water = capacity;
                }
            
                if(plants[i+1] <= water)
                {
                    water -= plants[i+1];
                    steps++;
                }
            }
        
            return steps;
        }
    }
}