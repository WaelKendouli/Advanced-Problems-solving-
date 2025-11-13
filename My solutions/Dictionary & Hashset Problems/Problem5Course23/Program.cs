using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5Course23
{
    internal class Program
    {
//        Phonebook Application
//Problem: Implement a phonebook where you can store and retrieve contact numbers using names.

//Output:

//Alice's Phone: 123-456-7890

//Bob's Phone: 987-654-3210



        static void Main(string[] args)
        {
            Dictionary<string, string> PhoneBook = new Dictionary<string, string>();
            PhoneBook.Add("Alice", "123-456-7890");
            PhoneBook.Add("Phone", "987-654-3210");

            foreach (var Phone in PhoneBook)
            {
                Console.WriteLine($"{Phone.Key}'s Phone : {Phone.Value}");
            }

            Console.ReadKey();
        }
    }
}
