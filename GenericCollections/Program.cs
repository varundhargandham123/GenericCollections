using System;
using System.Collections.Generic;
namespace GenericCollectionsdemo
{
    class GenericCollections
    {
        /// <summary>
        /// a list of objects.
        /// </summary>
        public void list()
        {
            List<int> list = new List<int>();
            list.Add(42);
            list.Add(24);
            list.Add(31);
            list.Add(26);
            list.Add(26);
            list.Add(42);
            list.Remove(26);
            list.Add(10);
            list.Add(100);          
            list.Sort();
            foreach (var num in list)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// a collection of key/value pairs.
        /// </summary>
        public void sortedList()
        {
            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(1,"One");
            sortedList.Add(2,"two");
            sortedList.Add(3,"three");
            sortedList.Add(4,"four");
            sortedList.Add(5,"five");
            sortedList.Add(6,"six");
            sortedList.Remove(5);
            foreach (var num in sortedList)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// A collection of key/value pairs that are organized based on the key.
        /// </summary>
        public void dictionary()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(2, "Two");
            dictionary.Add(4, "four");
            dictionary.Add(5, "five");
            dictionary.Add(6, "six");
            dictionary.Remove(5);
           foreach (var num in dictionary)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// A last in, first out (LIFO) collection of objects.
        /// </summary>
        public void stack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine("Peek " + stack.Peek());
            Console.WriteLine("Pop " + stack.Pop());
            Console.WriteLine("Peek " + stack.Peek());
            foreach (var num in stack)
            {
                Console.WriteLine(num);
            }
        }

        /// <summary>
        /// A first in, first out (FIFO) collection of objects.
        /// </summary>
        public void queue()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Console.WriteLine("Peeked " + queue.Peek());
            Console.WriteLine("Dequeue " + queue.Dequeue());
            Console.WriteLine("Peeked " + queue.Peek());
            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("System.Collections.Generic Classes\n");
            GenericCollections genericcollections = new GenericCollections();
            Console.WriteLine("List");    
            genericcollections.list();
            Console.WriteLine("Sorted List");
            genericcollections.sortedList();
            Console.WriteLine("Dictionary");
            genericcollections.dictionary();
            Console.WriteLine("Stack");
            genericcollections.stack();
            Console.WriteLine("Queue");
            genericcollections.queue();
        }
    }
}
