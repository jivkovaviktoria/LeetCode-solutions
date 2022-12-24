using System;
using System.Collections.Generic;

namespace FirstUniqueCharacterInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = "leetcode";
            Console.WriteLine(FirstUniqChar(s)); //Expected: 0
        }
        
        //The method starts by creating a dictionary, called map, which will be used to store the characters in the
        //string as keys and the indexes of their occurrences as values. The dictionary is initialized as empty.

        //Then, the method iterates through the characters in the string using a for loop. For each character,
        //if it is not already present in the dictionary as a key, it is added to the dictionary along with a new list
        //containing its index. If the character is already present in the dictionary, its index is simply added to the
        //list of indexes stored in the dictionary for that character.

        //After the for loop has finished, the method then iterates through the values in the dictionary using a foreach loop.
        //For each value, which is a list of indexes, the method checks if the list has only one element. If it does,
        //the method checks if the index stored in the list is smaller than the current minimum index stored in the variable
        //minIdx. If it is, minIdx is updated to the index stored in the list.

        private static int FirstUniqChar(string s) {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        
            for(int i = 0; i < s.Length; i++)
            {
                if(!map.ContainsKey(s[i])) map.Add(s[i], new List<int>(){ i });
                else map[s[i]].Add(i);   
            }
        
            int minIdx = Int32.MaxValue;
            foreach(var val in map.Values)
                if(val.Count == 1 && val[0] < minIdx) minIdx = val[0];
        
            if(minIdx == Int32.MaxValue) return -1;
            return minIdx;
        
        }
    }
}