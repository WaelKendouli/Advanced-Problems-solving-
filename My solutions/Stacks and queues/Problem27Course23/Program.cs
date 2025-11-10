using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem27Course23
{
    internal class Program
    {
        //        Evaluate a Postfix Expression
        //Problem: Evaluate a postfix expression using a stack.

        //Example:
        //Input: "231*+9-"
        //Output: -4


        //Key Points:

        //Push numbers onto the stack.
        //Perform operations using the top two elements for each operator.
        //Step-by-Step Execution for "231*+9-"
        //1- Initial Expression: "231*+9-"

        //2- Processing the Characters:

        //Character 2:
        //Digit → Push 2 onto the stack.
        //    Stack: [2]
        //Character 3:
        //Digit → Push 3 onto the stack.
        //    Stack: [2, 3]
        //Character 1:
        //Digit → Push 1 onto the stack.
        //    Stack: [2, 3, 1]
        //Character *:
        //Operator → Pop 1 and 3 from the stack.
        //Multiply: 3 * 1 = 3
        //Push result (3) onto the stack.
        //Stack: [2, 3]
        //Character +:
        //Operator → Pop 3 and 2 from the stack.
        //Add: 2 + 3 = 5
        //Push result(5) onto the stack.
        //Stack: [5]
        //Character 9:
        //Digit → Push 9 onto the stack.
        //Stack: [5, 9]
        //Character -:
        //Operator → Pop 9 and 5 from the stack.
        //Subtract: 5 - 9 = -4
        //Push result(-4) onto the stack.
        //Stack: [-4]
        //3- Final Step:

        //The last element in the stack(-4) is popped and returned as the result.

        


        private static int PerformeOperations(int Number1, char operation, int Number2)
        {
            switch(operation)
            {
                case '+':
                    return Number1 + Number2;
                case '-':
                    return Number1 - Number2;
                case '*':
                    return Number1 * Number2;
                case '/':
                    return Number1 / Number2;
                default:
                    return 0;
            }

        }

        public static int EvaluatePostfixExpression(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new Exception("InvalidInput");
            }

            int num1, num2;
            string Operations = "+*-/";
            Stack<int> stkNumbers = new Stack<int>();
            int FinalResult = 0;

            foreach (char c in input)
            {
                if (!Operations.Contains(c))
                {
                    stkNumbers.Push(c-'0');// clean and efficent way in order to convert a character to int
                                           // example : c = 1 ASCII : 49 0 in ASCII equals 48 => 49 - 48 = 1
                }
                else
                {
                    if (stkNumbers.Count>=2)
                    {
                        num2 = stkNumbers.Pop();
                        num1 = stkNumbers.Pop();
                        
                        FinalResult = PerformeOperations(num1, c, num2);
                        stkNumbers.Push(FinalResult);
                    }
                    else
                    {
                        throw new Exception("Invalid postfix order");
                    }
                }


            }
            if (stkNumbers.Count!=1)
            {
                throw new Exception("Invalid postfix order");
            }


            return stkNumbers.Pop();

        }


        static void Main(string[] args)
        {

            string Input = "231*+9-";
            Console.WriteLine($"final result for {Input} : {EvaluatePostfixExpression(Input)}");
            Console.ReadKey();
        }
    }
}
