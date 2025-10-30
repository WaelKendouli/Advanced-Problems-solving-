using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6Course23
{
    internal class Program
    {

        class clsTicketsSimulation
        {
            private Queue<int> _queTickets = new Queue<int>();
            private void _ShowIssuedTicket(int TicketNumber)
            {
                Console.WriteLine($"Tickets {TicketNumber} issued\n\n");
            }
            public void AddTicket(int TicketNumber)
            {
                _queTickets.Enqueue(TicketNumber);
                _ShowIssuedTicket(TicketNumber);
            }

            private void _ShowRestTickets()
            {
                if (_queTickets.Count == 0)
                {
                    Console.WriteLine("No more tickets in the queue.\n");
                    return;
                }
                var ArrayTickets = _queTickets.ToArray();
                foreach (var Ticket in ArrayTickets)
                {
                    Console.Write($"{Ticket} , ");
                    if (_queTickets.Count == 1 || Ticket == ArrayTickets[ArrayTickets.Length - 1])
                    {
                        Console.Write($"{Ticket}");
                    }
                }
                Console.WriteLine();
            }
            public void StartSimulation()
            {
                Console.WriteLine("Ticketing System Simulation Started....\n\n");
                while (_queTickets.Count > 0)
                {
                    Console.WriteLine($" Processing Ticket : {_queTickets.Dequeue()}");
                    Console.Write("Remaining Tickets: ");
                    _ShowRestTickets();
                    Console.WriteLine("\n\n");
                }
                Console.WriteLine("Ticketing System Simulation Ended...\n");

            }



        }
        static void Main(string[] args)
        {
            clsTicketsSimulation Simulation = new clsTicketsSimulation();
            Simulation.AddTicket(101);
            Simulation.AddTicket(102);
            Simulation.AddTicket(103);
            Simulation.AddTicket(104);
            Simulation.AddTicket(105);

            Simulation.StartSimulation();
            Console.ReadKey();
        }
    }
}
