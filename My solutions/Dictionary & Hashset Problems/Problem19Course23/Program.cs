using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Problem19Course23
{
    internal class Program
    {
        //        Check if Two Arrays are Disjoint
        //Problem: Determine if two arrays have no common elements.

        //Example:
        //Input: nums1 = [1, 2, 3], nums2 = [4, 5, 6]
        //Output: True


        //Key Points:
        //Use a HashSet to check for common elements.

        public static bool AreArraysDisjoint(int[] num1 , int[]num2)
        {
            HashSet<int> hs1 = new HashSet<int>(num1);
            foreach (int item in num2)
            {
                if (hs1.Contains(item))
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[] num1 = { 1, 2, 3 };
            int[] num2 = { 4, 5, 6 };
            Console.WriteLine(AreArraysDisjoint(num1, num2));
            Console.ReadKey();
        }
    }
}
