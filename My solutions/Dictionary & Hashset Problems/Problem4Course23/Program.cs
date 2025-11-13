using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4Course23
{
    internal class Program
    {
        //        Count Word Frequencies in a Text
        //Problem: Count the frequency of each word in a given text.

        //Input: "hello world hello universe"

        //Output:

        //hello: 2

        //world: 1

        //﻿universe: 1

        public static void CountWords(string s)
        {
            
            Dictionary<string, int> dicCountWords = new Dictionary<string, int>();
            foreach (var  word in s.Split(' '))
            {
                if (!dicCountWords.ContainsKey(word))
                {
                    dicCountWords.Add(word, 1);
                }
                else
                {
                    dicCountWords[word]++;
                }
            }

            

            foreach (var item in dicCountWords)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

        }



        static void Main(string[] args)
        {
            CountWords("hello world hello universe");
            Console.ReadLine();
        }
    }
}
