using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1Course23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> Students = new Dictionary<string, double>();
            Students.Add("Alice", 15.5);
            Students.Add("Bob", 18);
            Students.Add("Charlie", 16.5);

            Console.WriteLine("Bob Grade : " + Students["Bob"]);

            Console.ReadLine();
        }
    }
}
