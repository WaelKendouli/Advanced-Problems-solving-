using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Problem14Course23
{
    internal class Program
    {
        //        Find Words That Can Be Typed Using One Row of Keyboard


        //Problem: Return all words that can be typed using one row of a QWERTY keyboard.

        //Example:
        //Input: ["Hello", "Alaska", "Dad", "Peace"]
        //    Output: ["Alaska", "Dad"]


        //Key Points:

        //Use a dictionary to map each character to its corresponding row.

        public static Dictionary<char, string> FillDictionary()
        {
            Dictionary<char, string> KeyBoardRows = new Dictionary<char, string>();
            string Row1Chars = "qwertyuiopQWERTYUIOP";
            string Row2Chars = "asdfghjklASDFGHJKL";
            string Row3Chars = "zxcvbnmZXCVBNM";

            foreach (char c in Row1Chars)
            {
                KeyBoardRows.Add(c, "Row1");
            }
            foreach (char c in Row2Chars)
            {
                KeyBoardRows.Add(c, "Row2");
            }
            foreach (char c in Row3Chars)
            {
                KeyBoardRows.Add(c, "Row3");
            }
            return KeyBoardRows;

        }

        public static bool IsWordAvailableToBeWrittenByOneRow(Dictionary<char , string> KeyBoardRows , string Row , string Word)
        {
            foreach (var c in Word)
            {
                if (KeyBoardRows[c] != Row)
                {
                    return false;
                }

                if (!KeyBoardRows.ContainsKey(c) )
                {
                    return false;
                }
            }
            return true;
        }

        public static List<string> WordsThatCanBeTypedUsingOneRowOfaQWERTYkeyBoard(string[] arr)
        {
            Dictionary<char, string> KeyBoardRows = FillDictionary();
            List<string> PossibleWords = new List<string>(); 
            foreach (var item in arr)
            {
                if ((IsWordAvailableToBeWrittenByOneRow(KeyBoardRows , "Row1" , item)
                    || IsWordAvailableToBeWrittenByOneRow(KeyBoardRows, "Row2", item)
                    || IsWordAvailableToBeWrittenByOneRow(KeyBoardRows, "Row3", item)
                    ))
                {
                    PossibleWords.Add(item);
                }
            }
            return PossibleWords;
        }


        static void Main(string[] args)
        {

            string[] Input = { "Hello", "Alaska", "Dad", "Peace" };

            Console.WriteLine(string.Join(",", WordsThatCanBeTypedUsingOneRowOfaQWERTYkeyBoard(Input)));

            Console.ReadKey();
        }
    }
}
