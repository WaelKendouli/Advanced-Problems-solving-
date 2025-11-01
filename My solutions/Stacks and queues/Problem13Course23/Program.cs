using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13Course23
{
    internal class Program
    {

        public static Queue<int> SortQueue(Queue<int> queue)
        {
            if (queue.Count==0)
            {
                throw new Exception("queue can't be sorted because it's empty");
            }
            Queue<int> SortedQueue = new Queue<int>();
            List<int> SortedList = queue.ToList();
            SortedList.Sort();
            foreach (var item in SortedList)
            {
                SortedQueue.Enqueue(item);
            }
            return SortedQueue;
        }
        // method 2 this is the best approach
        public static Queue<int> SortQueue2(Queue<int> queue)
        {
            List<int> SortedList = new List<int>(queue);
            SortedList.Sort();
            return new Queue<int>(SortedList);
        }
        // method 3 without using List.Sort() but it's a very slow and terrible approach 
        // in order to solve the problem , Complexity O(n3)

        public static Queue<int> UpdateQueue(int PreviousMinValue , Queue<int> Original)
        {
            Queue<int> BackupQueue = new Queue<int>();
            foreach (var item in Original.ToArray())
            {
                if (item!=PreviousMinValue)
                {
                    BackupQueue.Enqueue(item);
                }
            }
            return BackupQueue;
        }
        public static Queue<int> SortQueue3(Queue<int> queue)
        {
            if (queue.Count == 0)
            {
                throw new Exception("queue can't be sorted because it's empty");
            }
            Queue<int> SortedQueue = new Queue<int>();
            int MaxValue = 0;

            while (queue.Count>0)
            {
                SortedQueue.Enqueue(queue.Min());
                queue = UpdateQueue(queue.Min(), queue);

            }

            return SortedQueue;
        }

        // Method 4 : another terrible approach than 3 using only queues

        public static Queue<int> SortQueue4(Queue<int> queue)
        {
            if (queue.Count == 0)
            {
                throw new Exception("queue can't be sorted because it's empty");
            }

            Queue<int> TmpQueue = new Queue<int>(queue);
            Queue<int> SortedQueue = new Queue<int>(); 

            while (TmpQueue.Count > 0)
            {
                int Min = TmpQueue.Peek();
                int Count = TmpQueue.Count;

                // Find Minimum
                for (int i = 0; i < Count; i++)
                {
                    int current = TmpQueue.Dequeue();
                    if (current < Min)
                    {
                        Min = current;
                    }
                    TmpQueue.Enqueue(current);
                }
                Count = TmpQueue.Count;
                // move Min to sorted queue and delete it from tmp queue 
                for (int i = 0; i < Count; i++)
                {
                    int current = TmpQueue.Dequeue();
                    if (current!=Min)
                    {
                        TmpQueue.Enqueue(current);
                    }
                }
                SortedQueue.Enqueue(Min);

            }
            return SortedQueue;
        }

        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine($"Input : [" + string.Join(" , ", queue) + "]");

            Queue<int> SortedQueue = SortQueue4(queue);

            Console.WriteLine($"Output :[" + string.Join(" , ", SortedQueue) + "]");

            Console.ReadLine();
        }
    }
}
