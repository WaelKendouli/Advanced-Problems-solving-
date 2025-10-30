using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3Course23
{
    internal class Program
    {
        class Calculator
        {
            private bool _Initialised = false;
            private float Result = 0;
            private float PreviousResult = 0;
            private  Stack<float> stkUndo = new Stack<float>();

            private void ShowResult()
            {
                Console.Write(Result);
                Console.WriteLine("\n");
            }
            public void Addition(float N1, float N2)
            {
                PreviousResult = Result;
                Console.Write($"{N1} + {N2} = ");
                Result = N1 + N2;
                ShowResult();
                stkUndo.Push(PreviousResult);
            }

            public void Substraction(float N1, float N2)
            {
                PreviousResult = Result;
                Console.Write($"{N1} - {N2} = ");
                Result = N1 - N2;
                ShowResult();
                stkUndo.Push(PreviousResult);
            }
            public void Multiply(float N1, float N2)
            {
                PreviousResult = Result;
                Console.Write($"{N1} * {N2} = ");
                Result = N1 * N2;
                ShowResult();
                stkUndo.Push(PreviousResult);
            }
            public void Divide(float N1, float N2)
            {
                PreviousResult = Result;
                Console.Write($"{N1} / {N2} = ");
                Result = N1 / N2;
                ShowResult();
                stkUndo.Push(PreviousResult);
            }
            public void Undo()
            {
                Console.WriteLine($"Undo success , Old value : {stkUndo.Pop()}");
            }

        }
        static void Main(string[] args)
        {
            Calculator myCalculator = new Calculator();
            myCalculator.Addition(10, 20);
            myCalculator.Multiply(30, 40);
            myCalculator.Substraction(100, 80);
            myCalculator.Substraction(80, 70);
            myCalculator.Undo();
            myCalculator.Addition(100, 15);
            myCalculator.Addition(1500, 15);
            myCalculator.Undo();


            Console.ReadLine();
        }
    }
}
