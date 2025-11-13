using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6Course23
{
    internal class Program
    {
        /// <summary>
        /// Track Unique Visitors to a Website
      
        static void Main(string[] args)
        {
            HashSet<string> uniqueVisitors = new HashSet<string>();

            // Simulate website visitors
            uniqueVisitors.Add("192.168.1.1");
            uniqueVisitors.Add("192.168.1.2");
            uniqueVisitors.Add("192.168.1.1"); // Duplicate

            Console.WriteLine("Unique Visitors: " + uniqueVisitors.Count);
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
