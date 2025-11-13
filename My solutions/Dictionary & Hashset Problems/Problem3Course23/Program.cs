using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3Course23
{
    internal class Program
    {
//        Translate Words Between Languages
//Problem: Create a dictionary for translating words from one language to another.

//Output:

//Hello in Spanish: Hola

//Goodbye in Spanish: Adiós
        static void Main(string[] args)
        {
            Dictionary<string, (string Language, string synonyme)> LanguageTranslator = new Dictionary<string, (string, string)>();

            LanguageTranslator.Add("Hello / Hi" , ("Spanish" , "Hola"));
            LanguageTranslator.Add("Good morning", ("Spanish", "Buenos días"));
            LanguageTranslator.Add("Good afternoon", ("Spanish", "Buenas tardes"));
            LanguageTranslator.Add("Good evening / Good night", ("Spanish", "Buenas nouches"));

            foreach (var word in LanguageTranslator)
            {
                Console.WriteLine($" English : {word.Key} | {word.Value.Language} : {word.Value.synonyme} ");
            }


            Console.ReadLine();
        }
    }
}
