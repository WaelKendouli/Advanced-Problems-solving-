using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problem20Course23
{

    // Implement a Priority Queue
//Problem: Implement a priority queue where elements with higher priority are dequeued first.

//Example:
//Input: Enqueue(10, 1), Enqueue(5, 3), Enqueue(20, 2), Dequeue()
//Output: 5 (highest priority first)


//Key Points:

//Use a sorted data structure like a SortedList or a SortedDictionary to maintain priorities.
//Dequeue elements based on the priority value.

    internal class Program
    {
        public class PriorityQueue
        {
            

            private SortedDictionary<int, Queue<int>> queue = new SortedDictionary<int, Queue<int>>();

           


            public void Enqueue(int number , int priority)
            {
                if (!queue.ContainsKey(priority))
                {
                    queue[priority] = new Queue<int>();
                }
                queue[priority].Enqueue(number);


            }

            public int? Dequeue()
            {
                if (queue.Count==0)
                {
                    return null;
                }

                int HighestPriority = queue.Keys.Max();
                int value = queue[HighestPriority].Dequeue();
                if (queue[HighestPriority].Count == 0)
                {
                    queue.Remove(HighestPriority);
                }
                return value;
            }

        }
        static void Main(string[] args)
        {
            PriorityQueue MyQueue = new PriorityQueue();

            MyQueue.Enqueue(10, 1);
            MyQueue.Enqueue(5, 3);
            MyQueue.Enqueue(20, 2);
            Console.WriteLine(MyQueue.Dequeue());

            Console.ReadKey();
        }
    }
}
