using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7Course23
{
    internal class Program
    {
        class clsBackTracking
        {
         private   Stack<string> _stkBackTrack = new Stack<string>();
            
            
            public void AddActivity(string Activity)
            {
                _stkBackTrack.Push(Activity);
            }

            public void ShowActivities()
            {
                if (_stkBackTrack.Count>0)
                {
                   Console.Write("Activities :" + string.Join("->", _stkBackTrack.Reverse()));

                }
                else
                {
                    Console.WriteLine("No activities to show");
                }


            }
            public void BackTrack()
            {
                if (_stkBackTrack.Count==0)
                {
                    Console.WriteLine("No activities to show");
                    return;
                }
                _stkBackTrack.Reverse();
                Console.WriteLine("\nBack tracking...");
                while (_stkBackTrack.Count>0)
                {
                    Console.WriteLine($"Back to : {_stkBackTrack.Pop()}\n\n");
                }

            }

        }


        static void Main(string[] args)
        {
            clsBackTracking MyActivities = new clsBackTracking();
            MyActivities.AddActivity("Start ");
            MyActivities.AddActivity("Go to Gaz Station");
            MyActivities.AddActivity("Go to Super Market");
            MyActivities.AddActivity("Go To Work");
            MyActivities.AddActivity("Go to Cafe");
            MyActivities.AddActivity("Go Home.");
            MyActivities.ShowActivities();
            MyActivities.BackTrack();
            Console.ReadLine();



        }
    }
}
