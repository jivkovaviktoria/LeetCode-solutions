using System;
using System.Collections;
using System.Collections.Generic;

namespace DestinationCIty
{
    class Program
    {
        static void Main(string[] args)
        {
            var paths = new List<IList<string>>()
            {
                new List<string>() { "London", "New York" },
                new List<string>() { "New York", "Lima" },
                new List<string>() { "Lima", "Sao Paulo" }
            };

            Console.WriteLine(DestCity(paths));
            //Expected: "Sao Paulo"
        }

        //We add all of the CityA's (starting point) in hashset (If the city is CityA
        //that means there is a path to another city from it.) 
        //Then we check all destination cities (City B) in paths.
        //If the hashset with starting points (City A's) doesn't contain the destination city
        //that means there is no path from it to another city
        private static string DestCity(IList<IList<string>> paths)
        {
            HashSet<string> hs = new HashSet<string>();
            for (int i = 0; i < paths.Count; i++)
                hs.Add(paths[i][0]);
            
            foreach (var path in paths)
            {
                if (!hs.Contains(path[1]))
                    return path[1];
            }

            return "";
        }
    }
}