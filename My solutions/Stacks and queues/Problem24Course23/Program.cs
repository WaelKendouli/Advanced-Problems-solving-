using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem24Course23
{
    internal class Program
    {

        //        Reverse a String
        //Problem: Reverse a given string using a stack.

        //Input: "hello"
        //Output: "olleh"
        //Key Idea: Push each character onto the stack,
        //then pop them off to get the reversed string.

        public static string ReverseString(string Word)
        {
            Stack<char> stkReverse = new Stack<char>();
            foreach (char item in Word)
            {
                stkReverse.Push(item);                
            }


            string Reversed = "";
            while (stkReverse.Count>0)
            {
                Reversed += stkReverse.Pop();
            }
            return Reversed;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString("hello"));

            Console.ReadLine();
        }
    }
}
