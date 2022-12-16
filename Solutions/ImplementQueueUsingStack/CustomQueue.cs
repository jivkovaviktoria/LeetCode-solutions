namespace ImplementQueueUsingStack
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    //MyQueue class is a implementation of a queue data structure using two stacks
    public class MyQueue : IEnumerable<int>
    {

        private Stack<int> _baseStack = new Stack<int>();  //stores the elements of the queue
        private Stack<int> _stack = new Stack<int>();  //a stack used as auxiliary storage during the `Pop()` operation
        private int _current;  //an integer that stores the element at the front of the queue

        public MyQueue()
        {
        }

        //Adds a new element at the end of the queue
        public void Push(int x)
        {
            if (this._baseStack.Count == 0) this._current = x; // if the queue was previously empty, this is the item at the first position (current)
            this._baseStack.Push(x);
        }

        //Removes the element at the front of the queue and returns it
        public int Pop()
        {
            //First we transfer all of the elements (except the element at the front) to the helper stack
            while (this._baseStack.Count != 1)
            {
                this._current = this._baseStack.Pop();
                this._stack.Push(this._current);
            }

            //We save it(so we can return it at the end) and remove it from the queue
            int res = this._baseStack.Pop();

            //we transfer back to the base stack all of the elements
            while (this._stack.Count > 0)
                this._baseStack.Push(this._stack.Pop());

            return res;
        }

        public int Peek() => this._current;  //Returns the element at the front of the queue

        public bool Empty() => this._baseStack.Count == 0;  //Returns boolean whether the queue is empty or not


        //NOTE: The following code is not part of the problem
        private List<int> GetElements => this._baseStack.Reverse().ToList();
        public IEnumerator<int> GetEnumerator()
        {
            var collection = this.GetElements;
            foreach (var item in collection) yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}