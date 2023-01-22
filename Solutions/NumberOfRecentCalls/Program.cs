using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberOfRecentCalls
{
    class Program
    {
        static void Main(string[] args)
        {
            RecentCounter counter = new RecentCounter();
            List<int> result = new List<int>();
            
            result.Add(counter.Ping(1));
            result.Add(counter.Ping(100));
            result.Add(counter.Ping(3001));
            result.Add(counter.Ping(3002));

            Console.WriteLine(string.Join(",", result)); //Expected: null,1,2,3,3
        }
    }
    
    public class RecentCounter {

        private Queue<int> pings = new Queue<int>();

        public RecentCounter(){}

        public int Ping(int t)
        {
            pings.Enqueue(t);
            while (pings.Any())
            {
                if (t - pings.Peek() > 3000)
                {
                    pings.Dequeue();
                    continue;
                }
                
                break;
            }

            return pings.Count;
        }
    }
}