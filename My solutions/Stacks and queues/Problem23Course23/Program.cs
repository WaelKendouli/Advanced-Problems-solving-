using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Problem23Course23
{
    internal class Program
    {
        //  Find Middle Element in a Queue
        //Problem: Find the middle element of a queue without modifying it.

        //Example:
        //Input: Queue = [1, 2, 3, 4, 5]
        //Output: 3
        //Key Points:
        //Use a list to access the middle index.

        public static int? GetMiddeleItem(Queue<int> queue)
        {
            if (queue.Count==0)
            {
                return null;
            }
            int n = queue.Count;

            List<int> List = queue.ToList();

            if (n%2==0)
            {
                return List[(n / 2) - 1];
            }

            return List[n / 2];


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
            queue.Enqueue(7);


            Console.WriteLine(GetMiddeleItem(queue));

            Console.ReadLine();
        }
    }
}
