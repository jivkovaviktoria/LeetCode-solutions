using System;

namespace AverageSalaryExcludingTheMinimumAndMaximumSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            var salary = new int[] { 4000, 3000, 1000, 2000 };
            Console.WriteLine(Average(salary)); //Expected: [2500.00000]
        }

        //LINQ Solution => return salary.Where(x => x != salary.Max() && x != salary.Min()).Average();
        private static double Average(int[] salary)
        {
            //We use bubble sorting algorithm
            int temp;
            for (int j = 0; j <= salary.Length - 2; j++)
            {
                for (int i = 0; i <= salary.Length - 2; i++)
                {
                    if (salary[i] > salary[i + 1])
                    {
                        temp= salary[i + 1];
                        salary[i + 1] = salary[i];
                        salary[i] = temp;
                    }
                }
            }
        

            double ans = 0;
            int count = 0;
            
            //We remove the minimum and the maximum salary
            salary[0] = 0;
            salary[salary.Length-1] = 0;
            
            //Finding the acerage salary
            for(int i = 0; i < salary.Length; i++)
            {
                if(salary[i] != 0)
                {
                    ans+= salary[i];
                    count++;
                }
            }
        
            return ans/count;
        }
    }
}