using System;

namespace AddDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "NESWW";
            Console.WriteLine(IsPathCrossing(path)); //Expected: True
        }
        
        public static bool IsPathCrossing(string path) {
            HashSet<(int x, int y)> moves = new(){(0, 0)};
        
            int x = 0, y = 0;
        
            for(int i = 0; i < path.Length; i++){
                if(path[i] == 'N') y++;
                else if(path[i] == 'S') y--;
                else if(path[i] == 'E') x++;
                else x--;
            
                if(moves.Contains((x, y))) return true;
            
                moves.Add((x, y));
            }
        
            return false;
        }
    }
}