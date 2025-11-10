using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem18Course23
{
    internal class Program
    {
        public class MyCustomQueue<T>
        {
            private Stack<T> _stkEnqueue = new Stack<T>();
            private Stack<T> _stkDequeue = new Stack<T>();

            public void Enqueue(T value)
            {
                _stkEnqueue.Push(value);  
            }
            public T Dequeue()
            {
                if (_stkEnqueue.Count==0)
                {
                    throw new Exception("Queue is empty cannot dequeue any more ");
                }

                if (_stkEnqueue.Count>0)
                {
                 _stkDequeue.Push(_stkEnqueue.Pop());   
                }


                return _stkDequeue.Pop();

            }
            public void ShowContent()
            {
                Console.WriteLine("[" + string.Join(",", _stkEnqueue.Reverse()) + "]");
            }

            public bool IsEmpty()
            {
                return (_stkEnqueue.Count == 0 && _stkDequeue.Count == 0);
            }

        }

        static void Main(string[] args)
        {
            MyCustomQueue<int> MyQueue = new MyCustomQueue<int>();

            MyQueue.Enqueue(1);
            MyQueue.Enqueue(2);
            MyQueue.Enqueue(3);
            MyQueue.Enqueue(4);
            MyQueue.Dequeue();
            MyQueue.ShowContent();

            Console.ReadLine();
        }
    }
}
