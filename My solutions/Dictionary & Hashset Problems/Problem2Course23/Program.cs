using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2Course23
{
    internal class Program
    {

// Store Book Information
//Problem: Store information about books(Title, Author) using their ISBN as the key.

//Note: Use Dictionary and Tuple.

//Output:

//ISBN: 978-3-16-148410-0, Title: The Great Gatsby, Author: F.Scott Fitzgerald

//ISBN: 978-1-61-729494-5, Title: C# in Depth, Author: Jon Skee
        static void Main(string[] args)
        {
            Dictionary<string, (string Title , string Author)> Books = new Dictionary<string, (string , string)>();
            Books.Add("978-3-16-148410-0", ("The Great Gatsby " , "F.Scott Fitzgerald"));
            Books.Add("978-1-61-729494-5", ("C# in Depth" , "Jon Skee"));

            foreach (var book in Books)
            {
                Console.WriteLine($"ISBN  :{book.Key}  Title : {book.Value.Title} , Author {book.Value.Author}" );
            }


            Console.ReadKey();
        }
    }
}
