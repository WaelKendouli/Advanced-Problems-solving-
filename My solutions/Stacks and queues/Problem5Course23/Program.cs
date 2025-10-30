using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5Course23
{
    internal class Program
    {
        class clsTrafficLightSimulation
        {
            private Queue<string> _queRoad = new Queue<string>();
            public void AddVehicle(string vehicle)
            {
                _queRoad.Enqueue(vehicle);

            }

            private void _ShowRestVehicles()
            {
                if (_queRoad.Count==0)
                {
                    Console.WriteLine("No vehicles waiting.\n");
                    return;
                }
                foreach (var Vehicle in _queRoad.ToArray())
                {
                    Console.Write($"{Vehicle}  ");
                }
                Console.WriteLine();
            }
            public void StartSimulation()
            {
                Console.WriteLine("Traffic Signal Simulation Started...\n\n");
                while (_queRoad.Count>0)
                {
                    Console.WriteLine($"{_queRoad.Dequeue()} has passed the signal.");
                    Console.Write("Vehicles Waiting : ");
                    _ShowRestVehicles();
                    Console.WriteLine("\n\n");
                }
                Console.WriteLine("Traffic Signal Simulation Ended.\n");

            }



        }


        static void Main(string[] args)
        {
            clsTrafficLightSimulation Road = new clsTrafficLightSimulation();
            Road.AddVehicle("Car 1");
            Road.AddVehicle("Truck 1");
            Road.AddVehicle("Bike 1");
            Road.AddVehicle("Bus 1");
            Road.StartSimulation();
            Console.ReadLine();
        }
    }
}
