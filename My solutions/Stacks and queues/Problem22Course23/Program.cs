using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Problem22Course23
{
    internal class Program
    {
        //        Clone a Queue Without Using Extra Space
        //Problem: Clone a queue such that the original queue remains unchanged.

        //Example:
        //Input: Queue = [1, 2, 3, 4]
        //Output: Clone = [1, 2, 3, 4]


        //Key Points:

        //Use recursion to clone the queue while keeping the original intact.

        public static Queue<int> CloneQueue(Queue<int> Queue)
        {
            if (Queue.Count==0)
            {
                return new Queue<int>();
            }

            int front = Queue.Dequeue();
            Queue<int> Clone = CloneQueue(Queue);
            Queue.Enqueue(front);
            Clone.Enqueue(front);
            return Clone;
        }
        static void Main(string[] args)
        {
            Queue<int> Queue = new Queue<int>();

            Queue.Enqueue(1);
            Queue.Enqueue(2);
            Queue.Enqueue(3);
            Queue.Enqueue(4);
            Queue.Enqueue(5);
            Queue.Enqueue(6);

            
            Queue<int> Clone = CloneQueue(Queue);



            Console.ReadLine();
        }
    }
}
