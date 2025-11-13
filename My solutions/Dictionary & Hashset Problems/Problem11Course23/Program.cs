using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problem11Course23
{
    internal class Program
    {
        //        Find Majority Element
        //Problem: Find the majority element in an array(element appearing more than n/2 times).

        //Example:
        //Input: [3, 2, 3]
        //Output: 3

        //Key Points:

        //Use a dictionary to count frequencies.
        public static int MajorityElements(int[] arr)
        {
            int Half = arr.Length / 2;
            Dictionary<int, int> dElements = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!dElements.ContainsKey(arr[i]))
                {
                    dElements.Add(arr[i], 1);
                }
                else
                {
                    dElements[arr[i]]++;
                }

                if (dElements[arr[i]]>Half)
                {
                    return arr[i];
                }
            }


            return -1;
        }

        static void Main(string[] args)
        {
            int[] Elements = { 3, 2, 3  };
            Console.WriteLine($"Majority element {MajorityElements(Elements)}");
            Console.ReadKey();
        }
    }
}
