using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Problem11Course23
{
    internal class Program
    {
        public static Stack<int> TurnIntoSatck(Queue<int> queue)
        {
            if (queue.Count==0)
            {
                return null;
            }
            Stack<int> stack = new Stack<int>();
            foreach (var item in queue.ToArray())
            {
                stack.Push(item);
            }
            return stack;

        }

        public static bool isQueuePalindrome(Queue<int> queue , Stack<int> stack)
        {
            if (queue.Count==0||stack.Count==0)
            {
                throw new Exception("Stack or Queue are empty , not suitable for the operation");
            }

            while (queue.Count>0 && stack.Count>0)
            {
                int QueueValue = queue.Dequeue();
                int StackValue = stack.Pop();

                if (StackValue!=QueueValue)
                {
                    return false;
                }

            }
            return true;
        }


        static void Main(string[] args)
        {
            Queue<int> Queue = new Queue<int>();
            Queue.Enqueue(1);
            Queue.Enqueue(2);
            Queue.Enqueue(3);
            Queue.Enqueue(2);
            Queue.Enqueue(1);

          
            Stack<int> stack = TurnIntoSatck(Queue);

            Console.WriteLine($"Is queue Palindrome : {isQueuePalindrome(Queue, stack)}");
            Console.ReadLine();
        }
    }
}
