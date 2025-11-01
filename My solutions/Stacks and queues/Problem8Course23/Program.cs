using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8Course23
{
    internal class Program
    {
        class clsTaskScheduling
        {
            private Queue<string> _TaskQueue = new Queue<string>();

            public void AddTask(string Task)
            {
                _TaskQueue.Enqueue(Task);
            }

            public void Execute()
            {
                if (_TaskQueue.Count==0)
                {
                    Console.WriteLine("No Tasks to execute");
                    return;
                }
                Console.WriteLine("Executing Tasks ... \n");

                while (_TaskQueue.Count>0)
                {
                    Console.Write($"Executing {_TaskQueue.Dequeue()}\n\n");
                    
                }



            }


        }

        static void Main(string[] args)
        {
            clsTaskScheduling Tasks = new clsTaskScheduling();

            Tasks.AddTask("Task1");
            Tasks.AddTask("Task2");
            Tasks.AddTask("Task3");
            Tasks.AddTask("Task4");

            Tasks.Execute();
            Console.ReadLine();
        }
    }
}
