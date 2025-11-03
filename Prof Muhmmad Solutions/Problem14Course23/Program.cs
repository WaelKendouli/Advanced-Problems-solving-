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
        public static void InterleaveQueueElements(Queue<int> queue)
        {
            if (queue.Count==0)
            {
                throw new Exception("queue cannot be empty");
            }

            int Half = queue.Count / 2;
            Stack<int> stkSplit = new Stack<int>();
            // Queue content : 1|2|3|4|5|6|
            for (int i = 0; i < Half; i++)
            {
                stkSplit.Push(queue.Dequeue());
            }
            // Queue content : |4|5|6|

            while (stkSplit.Count>0)
            {
                queue.Enqueue(stkSplit.Pop());
            }
            // Queue content : 4|5|6|3|2|1|

            for (int i = 0; i < Half; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
            // Queue content : 3|2|1|4|5|6|
            for (int i = 0; i < Half; i++)
            {
                stkSplit.Push(queue.Dequeue());
            }
            // Queue content : |4|5|6|
            while (stkSplit.Count>0)
            {
                queue.Enqueue(stkSplit.Pop());
                queue.Enqueue(queue.Dequeue());
            }
            // Queue : |1|4|2|5|3|6|


        }

        static void Main(string[] args)
        {
            Queue<int> queMyQueue = new Queue<int>();
            queMyQueue.Enqueue(1);
            queMyQueue.Enqueue(2);
            queMyQueue.Enqueue(3);
            queMyQueue.Enqueue(4);
            queMyQueue.Enqueue(5);
            queMyQueue.Enqueue(6);

            Console.WriteLine($"Original queue : [ "+string.Join("," , queMyQueue)+"]");
            InterleaveQueueElements(queMyQueue);
            Console.WriteLine($"InterLeaved queue : [ "+string.Join("," , queMyQueue)+"]");


            Console.ReadLine();
        }
    }
}
