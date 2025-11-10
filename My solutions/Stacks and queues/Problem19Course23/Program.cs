using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem19Course23
{
    internal class Program
    {

        public static Queue<int> Rearrange_Queue_Alternately(Queue<int> queue)
        {
            List<int> lsElements = new List<int>(queue);
            Queue<int> quResult = new Queue<int>();
            int n = lsElements.Count;

            for (int i = 0; i < n/2; i++)
            {
                quResult.Enqueue(lsElements[i]);
                quResult.Enqueue(lsElements[n - i - 1]);

            }
            if (n%2!=0)
            {
                quResult.Enqueue(lsElements[n / 2]);
            }

            return quResult;

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
            Console.WriteLine("[" + string.Join(" , ", queue) + "]\n\n");

            Queue<int> quResult = Rearrange_Queue_Alternately(queue);

            Console.WriteLine("[" + string.Join(" , ", quResult) + "]");

            Console.ReadKey();
        }
    }
}
