using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problem21Course23
{
    internal class Program
    {
        //        Rearrange Even and Odd Elements
        //        Rearrange Even and Odd Elements
        //Problem: Rearrange a queue such that all even numbers appear before
        //odd numbers while maintaining their order.


        //Example:
        //Input: Queue = [1, 2, 3, 4, 5, 6]
        //        Output: Queue = [2, 4, 6, 1, 3, 5]


        //Key Points:

        //Use two additional queues to separate even and odd elements.
        //Combine them back into the original queue.

        //Method 1 : Using two queues 
        public static void Rearrange_Even_and_Odd_Elements(Queue<int> queue)
        {
            if (queue.Count==0)
            {
                throw new Exception("queue is empty");
            }

            Queue<int> queOddNumbers = new Queue<int>();
            Queue<int> queEvenNumbers = new Queue<int>();

            while (queue.Count>0)
            {
                if (queue.Peek()%2==0)
                {
                    queEvenNumbers.Enqueue(queue.Dequeue());
                }
                else
                {
                    queOddNumbers.Enqueue(queue.Dequeue());

                }
            }


            while (queEvenNumbers.Count>0)
            {
                queue.Enqueue(queEvenNumbers.Dequeue());
            }


            while (queOddNumbers.Count>0)
            {
                queue.Enqueue(queOddNumbers.Dequeue());
            }


        }


       


        static void Main(string[] args)
        {

            Queue<int> MyQueue = new Queue<int>();
            MyQueue.Enqueue(1);
            MyQueue.Enqueue(2);
            MyQueue.Enqueue(3);
            MyQueue.Enqueue(4);
            MyQueue.Enqueue(5);
            MyQueue.Enqueue(6);
            Rearrange_Even_and_Odd_Elements(MyQueue);

            Console.WriteLine("[" + string.Join(",", MyQueue) + "]");

            Console.ReadLine();
        }
    }
}
