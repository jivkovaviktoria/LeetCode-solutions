using System;
using System.Collections.Generic;

namespace FindIfPathExistInGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6, source = 0, destination = 5;
            int[][] edges = new int[][]
            {
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 3, 5 },
                new int[] { 5, 4 },
                new int[] { 4, 3 }
            };

            Console.WriteLine(ValidPath(n, edges, source, destination)); //Expected: false
        }

        //The method first constructs a dictionary representing the graph,
        //with the keys being the nodes and the values being lists of nodes
        //that are connected to the key node by an edge.
        //It then uses a depth-first search algorithm to traverse the graph and check
        //if there is a path from the source node to the destination node.
        //The ExistPath function is used to recursively search the graph and
        //keep track of the nodes that have been visited using a HashSet to avoid revisiting nodes.
        //If the destination node is reached, the function returns true.
        //If the destination is not reached and all reachable nodes have been visited, the function returns false.
        private static bool ValidPath(int n, int[][] edges, int source, int destination) {
        
            Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        
            foreach(var x in edges)
            {
                int from = x[0];
                int to = x[1];
            
                if(graph.ContainsKey(from) == false) graph.Add(from, new List<int>());
                graph[from].Add(to);
            
                if(graph.ContainsKey(to) == false) graph.Add(to, new List<int>());
                graph[to].Add(from);
            }
        
            HashSet<int> visited = new HashSet<int>();
        
            return ExistPath(source);
            
            bool ExistPath(int node)
            {
                if(node == destination) return true;
                if(visited.Contains(node)) return false;
            
                visited.Add(node);
            
                foreach(var x in graph[node])
                    if(ExistPath(x)) return true;
            
                return false;
            }
        }
    }
}