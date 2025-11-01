using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9Course23
{
    internal class Program
    {

        class clsCustomersScheduling
        {
            private Queue<string> _CustomersQueue = new Queue<string>();

            public void AddCustomer(string Customer)
            {
                _CustomersQueue.Enqueue(Customer);
            }

            public void Serve()
            {
                if (_CustomersQueue.Count == 0)
                {
                    Console.WriteLine("No Customers to serve");
                    return;
                }
                Console.WriteLine("Serving customers ... \n");

                while (_CustomersQueue.Count > 0)
                {
                    Console.Write($"Serving {_CustomersQueue.Dequeue()}\n\n");

                }
            }


        }
        static void Main(string[] args)
        {
            clsCustomersScheduling Service = new clsCustomersScheduling();

            Service.AddCustomer("Wael");
            Service.AddCustomer("Hamid");
            Service.AddCustomer("Sami");
            Service.AddCustomer("James");

            Service.Serve();

            Console.ReadLine();

        }
    }
}
