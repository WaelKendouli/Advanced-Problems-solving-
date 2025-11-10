using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem25Course23
{
    internal class Program
    {
        //        Check Balanced Parentheses
        //Problem: Check if a given string has balanced parentheses.

        //Input: "({[]})" or "({[)]}"
        //Output: true for "({[]})" and false for "({[)]}"
        //Key Idea: Use a stack to keep track of opening brackets and ensure they are closed in the correct order.

        public static bool CheckBalancedParentheses(string Input)
        {
            Stack<char> stkChars = new Stack<char>();

            foreach (char Character in Input)
            {
                if (Character == '(' || Character == '[' || Character == '{')
                {
                    stkChars.Push(Character);
                }
                else if (Character ==')' || Character == ']' || Character == '}')
                {
                    if (stkChars.Count == 0)
                    {
                        return false;
                    }

                    char Top = stkChars.Pop();

                    if ((Character == ')'&& Top!='(')
                        || (Character == ']' && Top != '[')
                        || (Character == '}' && Top != '{'))
                    {
                        return false;
                    }


                }
            }

            return stkChars.Count == 0;

        }


        static void Main(string[] args)
        {
            Console.WriteLine(CheckBalancedParentheses("([{}])"));
            Console.WriteLine(CheckBalancedParentheses("({[}])"));

            Console.ReadLine();
        }
    }
}
