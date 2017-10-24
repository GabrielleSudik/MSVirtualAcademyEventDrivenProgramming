using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace MSVirtualAcademyEventDrivenProgramming

//this is probably all brand new stuff

//"events" are what allow developers to respond to stuff
//things like the appliation startup is an event
//other stuff in like, in GUIs, hovering on buttons, pressing buttons,
//drag and dropping, clicking links, etc.
//programmers write code to say what will happen when an event occurs
//.NET framework (and others) already know the events
//then attach the code to the event

//this exercise will work with a timer. 
//after a certain amount of time, our event will occur
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);
            //you needed to add a using statement for Timer. easy.
            //a lot of what's here is governed by that library, you didn't really learn it.

            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Elapsed += MyTimer_Elapsed1;
            //those two lines started the two methods below

            myTimer.Start();

            Console.WriteLine("Press enter to remove red event.");

            Console.ReadLine();

            myTimer.Elapsed -= MyTimer_Elapsed1;
            //this line stopped one of the methods.

            Console.ReadLine();
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Elapsed: {e.SignalTime}");
        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Elapsed: {e.SignalTime}");
        }
    }
}
