using System;

namespace StudentAttendanceRecordI
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "PPALLP";
            Console.WriteLine(CheckRecord(s)); //Expected: true
        }
        
        public static bool CheckRecord(string s) {
            int lateCount = 0, absentCount = 0;
        
            for(int i = 0; i < s.Length; i++){
                if(s[i] == 'L') lateCount++;
                else lateCount = 0;
            
                if(s[i] == 'A') absentCount++;
            
                if(lateCount == 3 || absentCount == 2) return false;
            }
        
            return true;
        }
    }
}