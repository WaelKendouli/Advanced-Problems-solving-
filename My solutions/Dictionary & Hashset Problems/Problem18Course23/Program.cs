using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Problem18Course23
{
    internal class Program
    {
        //        Find Numbers Disappeared in an Array
        //Problem: Find all numbers missing from the range 1 to n in an array.

        //Example:
        //Input: [4, 3, 2, 7, 8, 2, 3, 1]
        //Output: [5, 6]


        //Key Points:
        //Use a HashSet to track existing numbers.
        public static int[] FindMissingNumbers(int[] Numbers)
        {
            HashSet<int> hs1 = new HashSet<int>(Numbers);
            int n = Numbers.Length;
            List<int> MissingNumbers = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (!hs1.Contains(i))
                {
                    MissingNumbers.Add(i);
                }
            }

            return MissingNumbers.ToArray();
        }

        static void Main(string[] args)
        {
            int[] Numbers = { 4, 3, 2, 7, 8, 2, 3, 1 };

            Console.WriteLine(string.Join(",", FindMissingNumbers(Numbers)));
            Console.ReadLine();
        }
    }
}
