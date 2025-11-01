using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10Course23
{
    internal class Program
    {

        class clsMyQueue
        {
            private Queue<int> _MyQueue = new Queue<int>();
            private Stack<int> _stkMyStack = new Stack<int>();

            public void Add(int number)
            {
                _MyQueue.Enqueue(number);
            }

            public void Show()
            {
                if (_MyQueue.Count==0)
                {
                    Console.WriteLine("Queue is empty");
                    return;
                }
                Console.WriteLine(" Content of my queue : [" + string.Join(",", _MyQueue) + "]");
            }

            public void Reverse()
            {
                if (_MyQueue.Count==0)
                {
                    return;
                }
                while (_MyQueue.Count>0)
                {
                    _stkMyStack.Push(_MyQueue.Dequeue());
                }
                while (_stkMyStack.Count>0)
                {
                    _MyQueue.Enqueue(_stkMyStack.Pop());
                }

            }

        }

        static void Main(string[] args)
        {
            clsMyQueue MyQueue = new clsMyQueue();
            MyQueue.Add(1);
            MyQueue.Add(2);
            MyQueue.Add(3);
            MyQueue.Add(4);
            MyQueue.Add(5);
            Console.WriteLine("Before reversing : ");
            MyQueue.Show();
            MyQueue.Reverse();
            Console.WriteLine("After reversing : ");
            MyQueue.Show();

            Console.ReadLine();
        }
    }
}
