using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem28Course23
{
    internal class Program
    {
        //        Basic Calculator
        //Problem: Evaluate a mathematical expression containing +, -, (, ) without * or /.

        //Example:
        //Input: "1 + (2 - 3)"
        //Output: 0


        //Key Points:
        //Use a stack to handle parentheses and maintain the current sum.

        public static int Calculate(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                throw new Exception("Invalid Input");
            }


            int number = 0, result = 0, sign = 1;
            Stack<int> stkNumbers = new Stack<int>();

            foreach (var c in s)
            {
                if (char.IsDigit(c))
                {
                    number = number * 10 + (c - '0');
                }
                else
                {
                    switch (c)
                    {
                        case '+':
                            result += sign * number;
                            sign = 1;
                            number = 0;
                            break;
                        case '-':
                            result -= sign * number;
                            sign = -1;
                            number = 0;
                            break;
                        case '(':
                            stkNumbers.Push(result);
                            stkNumbers.Push(sign);
                            result = 0;
                            sign = 1;
                            break;
                        case ')':
                            result += sign * number;
                            number = 0;
                            result *= stkNumbers.Pop();
                            result += stkNumbers.Pop();
                            break;

                    }
                }
            }
            result += number * sign;

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Calculate("3+(2+1)"));


            Console.ReadLine();
        }
    }
}
