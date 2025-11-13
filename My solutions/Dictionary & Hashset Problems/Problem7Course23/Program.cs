using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7Course23
{
    internal class Program
    {

//        Check for Duplicate Entries in Real-Time
//Problem: Detect duplicates as data is added
        static void Main(string[] args)
        {
            HashSet<string> DataEntries = new HashSet<string>();
            string[] Data = { "A", "B", "C", "B" , "C" };

            foreach (var item in Data)
            {
                if (!DataEntries.Add(item))
                {
                    Console.WriteLine($"Duplication detected : {item}");
                }

            }

            Console.ReadLine();
        }
    }
}
