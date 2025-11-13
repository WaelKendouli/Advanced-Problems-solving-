using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Problem20Course23
{
    internal class Program
    {

                    //        Check If a Sentence Is Pangram
                    //Problem: Check if a sentence contains every letter of the English alphabet at least once.

                    //Example:


                    //Input: "The quick brown fox jumps over the lazy dog"
                    //Output: True

                    //Key Points:

                    //Use a HashSet to store unique letters.
        public static bool CheckIfSentenceIsPangram(string sentence)
        {
            string Alphabet = "qwertyuiopasdfghjklzxcvbnm";

            HashSet<char> hsCheck = new HashSet<char>();
            foreach (char c in sentence)
            {
                if (char.IsLetter(c)&& !hsCheck.Contains(c))
                {
                    hsCheck.Add(char.ToLower(c));
                }
            }


            foreach (char c in Alphabet)
            {
                if (!hsCheck.Contains(c))
                {
                    return false;
                }
            }

            return true;

        }
        // method 2 more effecient 

        public static bool IsPangram(string sentence)
        {
            HashSet<char> hsCheck = new HashSet<char>();
            foreach (char c in sentence.ToLower())
            {
                if (char.IsLetter(c))
                {
                    hsCheck.Add(c);
                }
            }

            return hsCheck.Count==26;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(IsPangram("The quick brown fox jumps over the lazy dog"));
            Console.ReadKey();
        }
    }
}
