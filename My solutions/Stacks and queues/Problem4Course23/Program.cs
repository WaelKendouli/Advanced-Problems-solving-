using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4Course23
{
    internal class Program
    {

        class clsPrinter
        {
            private string Page { get; set; }

            private Queue<string> _quePrinter = new Queue<string>();

            public void AddPage(string Content)
            {
                _quePrinter.Enqueue(Content);
            }

            public void PrintPages()
            {
                while (_quePrinter.Count > 0)
                {
                    Console.WriteLine("******************************\n\n");
                    Console.WriteLine($"\t{_quePrinter.Dequeue()}");
                    Console.WriteLine("\n\n******************************\n\n");
                }
            }


        }


        static void Main(string[] args)
        {
            clsPrinter printer = new clsPrinter();

            printer.AddPage("Hello , Text 1");
            printer.AddPage("Hello , Text 2");
            printer.AddPage("Hello , Text 3");
            printer.AddPage("Hello , Text 4");
            printer.AddPage("Hello , Text 5");
            printer.PrintPages();
            Console.ReadLine();
        }
    }
}
