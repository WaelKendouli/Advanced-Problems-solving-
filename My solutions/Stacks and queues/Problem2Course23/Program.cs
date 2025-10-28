using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2Course23
{
    internal class Program
    {
        class clsMyConvert
        {
          private static  Stack<int> stkResult = new Stack<int>();

            private static void ShowResultInBinary(int n)
            {
                string ResultInBinary = "";
                while (stkResult.Count!=0)
                {
                    ResultInBinary += stkResult.Pop();
                }
                Console.Write($"Converting {n} to binary : ");
                Console.WriteLine(ResultInBinary);
                stkResult.Clear();
            }
            public static void ToBinary(int n)
            {
                if (n < 0)
                {
                    Console.WriteLine("Negative numbers are not supported");
                    return;
                }

                int OriginalNumber = n;
                while (n > 0) 
                {
                    int Mod = n % 2;
                    n = n / 2;
                    stkResult.Push(Mod);
                }
                ShowResultInBinary(OriginalNumber);
            }
            
        }

        static void Main(string[] args)
        {
            clsMyConvert.ToBinary(10);
            clsMyConvert.ToBinary(100);
            clsMyConvert.ToBinary(200);
            clsMyConvert.ToBinary(500);
            clsMyConvert.ToBinary(16);
            clsMyConvert.ToBinary(-5);
            Console.ReadKey();
        }
    }
}
