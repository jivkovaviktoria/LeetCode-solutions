using System;

namespace ImplementQueueUsingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new MyQueue();

            queue.Push(1);
            queue.Push(2);
            queue.Push(3);

            Console.WriteLine(string.Join(",", queue)); //Expected: [1,2,3]

            queue.Pop();
            Console.WriteLine(string.Join(",", queue)); //Expected: [2, 3]

            Console.WriteLine(queue.Peek()); //Expected: 2

            Console.WriteLine(queue.Empty()); //Expected: false
        }
    }
}