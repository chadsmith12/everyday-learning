using System;
using System.Collections.Generic;

namespace AlgorithmTesting
{
    public class Queue<T>
    {
        private Stack<T> _pushStack;
        private Stack<T> _popStack;

        /// <summary>
        /// Initializes a new empty queue.
        /// </summary>
        public Queue()
        {
            _pushStack = new Stack<T>();
            _popStack = new Stack<T>();
        }

        /// <summary>
        /// Initializes a new queue that is empty
        /// with the capacity set.
        /// </summary>
        /// <param name="capacity">Capacity of the queue.</param>
        public Queue(int capacity)
        {
            _pushStack = new Stack<T>(capacity);
            _popStack = new Stack<T>(capacity);
        }

        /// <summary>
        /// Number items in the queue.
        /// </summary>
        public int Count
        {
            get
            {
                return _pushStack.Count + _popStack.Count;
            }
        }

        /// <summary>
        /// Adds an object to the end of the queue.
        /// </summary>
        /// <param name="item">item to add to the end of the queue.</param>
        public void Enqueue(T item)
        {
            _pushStack.Push(item);
        }

        /// <summary>
        /// Removes and returns the item at the beginning of the queue.
        /// </summary>
        /// <returns>Item beginning of the queue.</returns>
        public T Dequeue()
        {
            // the if the popstack is not empty, we know we can just use it
            if(_popStack.Count > 0)
            {
                return _popStack.Pop();
            }


            // until the push stack is empty, we need to move it all over.
            while(_pushStack.Count > 0)
            {
                _popStack.Push(_pushStack.Pop());
            }

            // now just pop the pop stack
            return _popStack.Pop();
        }

        /// <summary>
        /// Returns the first item in the queue without removing it.
        /// </summary>
        /// <exception cref="InvalidOperationException">If the queue is currently empty.</exception>
        /// <returns><The first item in the queue./returns>
        public T Peek()
        { 
            // popstack is not empty, peek from it
            if(_popStack.Count > 0)
            {
                return _popStack.Peek();
            }

            if(_pushStack.Count != 0)
            {
                T lastItem = _pushStack.Peek();
                // otherwise we have to get it from the push stack
                foreach (var item in _pushStack)
                {
                    lastItem = item;
                }

                return lastItem;
            }


            throw new InvalidOperationException("Tried to peek on an empty Queue");

        }
    }
}
