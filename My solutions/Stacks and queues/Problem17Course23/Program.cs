using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem17Course23
{
    internal class Program
    {
        public static void DetectFirst_non_RepeatingCharacters(string word)
        {
            Dictionary<char, short> dicCharacters = new Dictionary<char, short>();
            Queue<char> queElements = new Queue<char>();
            List<char> OutputList = new List<char>();

            foreach (char item in word)
            {
                // 1. Update dictionary count
                bool isExistInDictionary = dicCharacters.ContainsKey(item);
                if (!isExistInDictionary)
                {
                    dicCharacters.Add(item, 1);
                }
                else
                {
                    dicCharacters[item]++;
                }

                // 2. Always enqueue new characters (not just when queue is empty)
                // Every character gets added to queue when first encountered
                if (!isExistInDictionary)
                {
                    queElements.Enqueue(item);
                }

                // 3. Clean up the front of the queue - remove characters that are no longer valid
                while (queElements.Count > 0 && dicCharacters[queElements.Peek()] > 1)
                {
                    queElements.Dequeue();
                }

                // 4. Determine output AFTER all processing
                if (queElements.Count > 0)
                {
                    OutputList.Add(queElements.Peek());
                }
                else
                {
                    OutputList.Add('-');
                }
            }

            Console.WriteLine("[" + string.Join(", ", OutputList) + "]");
        }


        static void Main(string[] args)
        {
            DetectFirst_non_RepeatingCharacters("aabc");

            Console.ReadLine();
        }
    }
}
