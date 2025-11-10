using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15Course23
{
    internal class Program
    {
        public static void RotateQueue(Queue<int> Queue, int RotationsNumber)
        {
            if (Queue.Count==0||RotationsNumber<0)
            {
                throw new Exception("Cannot Implement the operation due to the emptiness of queue or rotation number is invalid");
            }
            while (RotationsNumber>0)
            {
                Queue.Enqueue(Queue.Dequeue());
                RotationsNumber--;
            }



        }


        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine("Before rotation :[" + string.Join(",", queue) + "]");
            RotateQueue(queue , 2);
            Console.WriteLine("After rotation :[" + string.Join(",", queue) + "]");



            Console.ReadLine();
        }
    }
}
