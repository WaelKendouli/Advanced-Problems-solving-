using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem1Course23
{
    class clsWebPage
    {
        public string Title { get; set; }
        public string URL { get; set; }

        public clsWebPage(string pageName, string uRL)
        {
            Title = pageName;
            URL = uRL;
        }
    }

    class clsWebBrowser
    {
        private  Stack<clsWebPage> stkBrowser = new Stack<clsWebPage>();
        private  Stack<clsWebPage> stkBrowserHistory = new Stack<clsWebPage>();

        public void GoBack()
        {
            if (stkBrowser.Count==1)
            {
                Console.WriteLine("\n\ncannot go back furthermore :-( \n\n");
                return;
            }
            stkBrowserHistory.Push(stkBrowser.Pop());
            Console.WriteLine("\n\n*************** Went back successfully *************\n\n");
            ShowCurrentPage();
        }

        public void AddNewPage(string PageName , string URL)
        {
            clsWebPage NewPage = new clsWebPage(PageName, URL);
            stkBrowser.Push(NewPage);
            ShowCurrentPage();        
        }

        private void ShowCurrentPage()
        {
            if (stkBrowser.Count==0)
            {
                Console.WriteLine("No web sites are visited yet");
                return;
            }
            clsWebPage CurrentPage = stkBrowser.Peek();
            Console.WriteLine("______________________________________________\n\n");
            Console.WriteLine($"Current web Page : Title {CurrentPage.Title} , URL : {CurrentPage.URL}");
            Console.WriteLine("\n\n______________________________________________");

        }

        public void GoNext()
        {
            if (stkBrowserHistory.Count == 0)
            {
                Console.WriteLine("No more Web Pages are Available to go next");
                return;
            }
            stkBrowser.Push(stkBrowserHistory.Pop());
            Console.WriteLine("\n\n*********** Moving Next ************** \n\n");
            ShowCurrentPage();
        }

        public void ShowBrowsingHistory()
        {
            Console.WriteLine("\n\n***********************************");
            Console.WriteLine("\n\n\tBrowsing History\t");
            Console.WriteLine("\n\n***********************************\n\n");


            foreach (var Page in stkBrowser.ToList())
            {
                Console.WriteLine($"Title : {Page.Title} , URL : {Page.URL}");
                Console.WriteLine("\n__________________________________\n");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            clsWebBrowser myBrowser = new clsWebBrowser();

            myBrowser.AddNewPage("Google", "https/Google.com");
            myBrowser.AddNewPage("GitHub", "https/Github.com");
            myBrowser.AddNewPage("Amazon", "https/amazon.com");
            myBrowser.AddNewPage("YouTube", "https/YouTube.com");

            myBrowser.ShowBrowsingHistory();
            myBrowser.GoBack();
            myBrowser.GoBack();
            myBrowser.GoBack();
            myBrowser.GoNext();
            myBrowser.GoNext();
            myBrowser.GoNext();

            Console.ReadKey();
        }
    }
}
