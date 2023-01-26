using System;

namespace Check_if_Binary_String_Has_at_Most_One_Segment_of_Ones
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "1001";
            Console.WriteLine(CheckOnesSegment(s)); //Expected: false
        }
        
        public static bool CheckOnesSegment(string s) {
            if(s == "10" || s.Contains("0") == false) return true;
            int idx1 = s.IndexOf("10");
            int idx2 = s.IndexOf("01");
        
            if(idx1 > -1 && idx1 > idx2) return true;
            return false;
        }
    }
}