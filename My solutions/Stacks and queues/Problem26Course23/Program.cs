using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem26Course23
{
    internal class Program
    {
        //  Check palindrome using a stack
        //Problem:
        //Check if a given string is a palindrome using a stack.

        //Input: "madam"
        //Output: true
        //Input: "hello"
        //Output: false

        private static bool IsPalindrome(string Word)
        {
            Stack<char> stkReverse = new Stack<char>();

            foreach (var item in Word)
            {
                stkReverse.Push(item);
            }
            

            foreach (var c in Word)
            {
                if (c!=stkReverse.Pop())
                {
                    return false;
                }
            }
            return true;
        }

        

        static void Main(string[] args)
        {
            string Word = "madam";

            Console.WriteLine($"is {Word} Palindrome ? : {IsPalindrome(Word)}\n\n");

            Word = "Hello";
            Console.WriteLine($"is {Word} Palindrome ? : {IsPalindrome(Word)}\n\n");
            Word = "POLOP";
            Console.WriteLine($"is {Word} Palindrome ? : {IsPalindrome(Word)}\n\n");

            Console.ReadLine();
        }
    }
}
