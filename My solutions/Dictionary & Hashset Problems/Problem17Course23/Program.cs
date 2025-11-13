using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17Course23
{
    internal class Program
    {
        //        Find Elements Not in the Second Array
        //Problem: Find all elements in the first array that are not in the second array.

        //Example:
        //Input: nums1 = [1, 2, 3, 4], nums2 = [3, 4, 5, 6]
        //Output: [1, 2]


        //Key Points:
        //Use a HashSet to store the second array's elements for quick lookups.


        // method 1
        public static HashSet<int> FindElements(int[] arr1 , int[] arr2)
        {
            HashSet<int> Hashset1 = new HashSet<int>(arr1);
            HashSet<int> Hashset2 = new HashSet<int>(arr2);
            Hashset1.ExceptWith(Hashset2);
            return Hashset1;
        }

        // method 2

        public static int[] FindElementsNotInTheSecondArray(int[] num1 , int[] num2)
        {
            HashSet<int> hs2 = new HashSet<int>(num2);
            List<int> Numbers = new List<int>();

            foreach (int num in num1)
            {
                if (!hs2.Contains(num))
                {
                 Numbers.Add(num);   
                }
                
            }

            return Numbers.ToArray();
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 3, 4, 5, 6 };


            Console.WriteLine(string.Join(",", FindElementsNotInTheSecondArray(arr1, arr2)));
            Console.ReadKey();
        }
    }
}
