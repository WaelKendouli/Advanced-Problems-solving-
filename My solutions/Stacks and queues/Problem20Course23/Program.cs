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
            private Queue<int> queue = new Queue<int>();

            private SortedDictionary<int, int> dicSortedElements = new SortedDictionary<int, int>();

            private void _FillQueueWithPrioritizedContent(int number , int priority)
            {

                dicSortedElements.Add(priority, number);

                while (queue.Count>0)
                {
                    queue.Dequeue();//clearing the queue first
                }
                int MaxPriority = dicSortedElements.Max(n => n.Key);
                while (MaxPriority>0)
                {
                    if (dicSortedElements.ContainsKey(MaxPriority))
                    {
                    queue.Enqueue(dicSortedElements[MaxPriority]);
                    }
                    MaxPriority--;
                }

            }
            public void Enqueue(int number , int priority)
            {
                _FillQueueWithPrioritizedContent(number, priority);
            }

            public int Dequeue()
            {
                return queue.Dequeue();
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
