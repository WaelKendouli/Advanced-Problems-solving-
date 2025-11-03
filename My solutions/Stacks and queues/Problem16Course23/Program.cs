using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem16Course23
{
    internal class Program
    {

        public static Queue<int> MergeSortedQueue(Queue<int> queue1, Queue<int> queue2)
        {
            if (queue1.Count==0||queue2.Count==0 || queue1.Count>queue2.Count || queue2.Count>queue1.Count)
            {
                throw new Exception("queues should not be empty and their sizes should be equal");
            }
            Queue<int> NewQueue = new Queue<int>();
            Queue<int> queBiggerNumbers = new Queue<int>();
            while (queue1.Count > 0 && queue2.Count > 0 && queue1.Count==queue2.Count)
            {
                var current1 = queue1.Dequeue();
                var current2 = queue2.Dequeue();
                if (current1==current2)
                {
                    NewQueue.Enqueue(current1);
                }
                if (current1>current2)
                {
                    NewQueue.Enqueue(current2);
                    queBiggerNumbers.Enqueue(current1);
                }
                else
                {
                    NewQueue.Enqueue(current1);
                    queBiggerNumbers.Enqueue(current2);

                }

            }
            while (queBiggerNumbers.Count>0)
            {
                NewQueue.Enqueue(queBiggerNumbers.Dequeue());
            }

            return NewQueue;
        }

        static void Main(string[] args)
        {
            Queue<int> queue1 = new Queue<int>();
            queue1.Enqueue(1);
            queue1.Enqueue(2);
            queue1.Enqueue(3);
            Queue<int> queue2 = new Queue<int>();
            queue2.Enqueue(4);
            queue2.Enqueue(5);
            queue2.Enqueue(6);

            Queue<int> NewQueue = MergeSortedQueue(queue1, queue2);

            Console.WriteLine("[" + string.Join(",", NewQueue) + "]");

            Console.ReadLine();
        }
    }
}
