using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem14Course23
{
    internal class Program
    {
        public static Queue<int> InterleaveQueueElements(Queue<int> queue)
        {
            if (queue.Count==0)
            {
                throw new Exception("Cannot performe the operation while queue is empty");
            }

            int count = queue.Count;

            Queue<int> InterleavedQueue = new Queue<int>();
            Stack<int> stkFirstHalf = new Stack<int>();
            Stack<int> stkSecondHalf = new Stack<int>();

            for (int i = 0; i < count/2; i++)
            {
                if (queue.Count>0)
                {
                 stkFirstHalf.Push(queue.Dequeue());   
                }
                
            }
            for (int i = 0; i < count / 2; i++)
            {
                if (queue.Count > 0)
                {
                    stkSecondHalf.Push(queue.Dequeue());
                }
            }

           
            for (int i = 0; i < count/2; i++)
            {
                if (stkFirstHalf.Count>0)
                {
                    InterleavedQueue.Enqueue(stkFirstHalf.Pop());
                }
                if (stkSecondHalf.Count>0)
                {
                    InterleavedQueue.Enqueue(stkSecondHalf.Pop());
                }

            }
            InterleavedQueue.Reverse();
            return InterleavedQueue;

        }

        static void Main(string[] args)
        {

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            Queue<int> InterLeavedQueue = InterleaveQueueElements(queue);

            Console.WriteLine($"Result : [" + string.Join(" , " , InterLeavedQueue) +"]");

            Console.ReadLine();
        }
    }
}
