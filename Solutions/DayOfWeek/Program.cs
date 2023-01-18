using System;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 31, month = 8, year = 2019;
            Console.WriteLine(DayOfTheWeek(day, month, year)); //Expected: Saturday

            int day2 = 18, month2 = 7, year2 = 1999;
            Console.WriteLine(DayOfTheWeek(day2, month2, year2)); //Expected: Sunday
        }
        
        public static string DayOfTheWeek(int day, int month, int year) {
            return new DateTime(year,month,day).DayOfWeek.ToString();
        }
    }
}