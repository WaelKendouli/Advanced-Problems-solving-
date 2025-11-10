using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem29Course23
{
    internal class Program
    {

        //        Remove Invalid Parentheses
        //Problem: Remove the minimum number of invalid parentheses to make the string valid.

        //Example:
        //Input: "(()))"
        //Output: "()" or "(())"

        //Key Points:

        //Use a stack to track mismatched parentheses.

        public static string RemoveInvalidParentheses(string s)
        {
            HashSet<int> InvalidIndeces = new HashSet<int>();
            Stack<int> stack = new Stack<int>();
            for (int i = 0;i <s.Length;i++ )
            {
                if (s[i] =='(')
                {
                    stack.Push(i);
                }
                else if (s[i] == ')')
                {
                    if (stack.Count==0)
                    {
                        InvalidIndeces.Add(i);
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }
            while (stack.Count>0)
            {
                InvalidIndeces.Add(stack.Pop());
            }

            char[] result = new char[s.Length - InvalidIndeces.Count];
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (!InvalidIndeces.Contains(i))
                {
                 result[index++] = s[i];   
                }
            }
            return new string (result);

        }

        static void Main(string[] args)
        {
            Console.WriteLine(RemoveInvalidParentheses("(()))((((("));
            Console.ReadLine();
        }
    }
}
