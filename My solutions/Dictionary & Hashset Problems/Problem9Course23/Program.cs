using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9Course23
{
    internal class Program
    {

        //        Find the Frequency of Each Character
        //Problem: Count the frequency of each character in a string.

        //Example:
        //Input: "hello"
        //Output: { 'h': 1, 'e': 1, 'l': 2, 'o': 1 }


        //Key Points:

        //Use a dictionary to map characters to their frequency.

        public static void CountCharacters(string s)
        {
            Dictionary<char, int> dicCounter = new Dictionary<char, int>();
            foreach (var item in s)
            {
                if (!dicCounter.ContainsKey(item))
                {
                    dicCounter.Add(item, 1);
                }
                else
                {
                    dicCounter[item]++;   
                }
            }
            Console.Write("{ ");

            foreach (var item in dicCounter)
            {
                Console.Write($" {item.Key} : {item.Value} ");
            }
            Console.Write(" }");


        }

        static void Main(string[] args)
        {

            CountCharacters("hello");

            Console.ReadLine();
        }
    }
}
