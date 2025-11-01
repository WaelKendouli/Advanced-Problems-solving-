using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12Course23
{
    internal class Program
    {

        class BinaryGenerator
        {
            public int Number { get; set; }
            public BinaryGenerator(int number)
            {
                this.Number = number;
            }
            private Stack<int> _TurnToBinary(int n)
            {
                Stack<int> stkBinaryResult = new Stack<int>();

                while (n>0)
                {
                    stkBinaryResult.Push(n%2);
                    n = n / 2;
                }
                return stkBinaryResult;
            }
            private string _TurnResultToString(Stack<int> ResultStack)
            {
                string BinaryResult = "";

                while (ResultStack.Count>0)
                {
                    BinaryResult += ResultStack.Pop().ToString();
                }
                return BinaryResult;
            }

            private void _ShowFinalResult(Stack<string> BinaryResults) // shows binary conversions from n to 1  
            {
                Console.WriteLine($"[ " + string.Join(" , ", BinaryResults) + "]");
            }

            public void GenerateBinaryNumbers()
            {
                Stack<string> queBinaryResult = new Stack<string>();
                while (this.Number>0)
                {
                    Stack<int> stkBinaryResult = _TurnToBinary(Number);
                    string ResultString = _TurnResultToString(stkBinaryResult);
                    queBinaryResult.Push(ResultString);
                    this.Number--;
                }
                _ShowFinalResult(queBinaryResult);
            }
        }

        static void Main(string[] args)
        {
            BinaryGenerator binaryGenerator = new BinaryGenerator(5);
            binaryGenerator.GenerateBinaryNumbers();
            Console.ReadLine();
        }
    }
}
