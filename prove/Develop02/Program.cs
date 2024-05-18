//This is my Journal Program! To exceed the requirements of the assignment, I decided to add a new menu option to the program: Motivate me!
//I used my Prompt Generator class to also store a list of motivational tid-bits that I wrote. 
//When the user selects this option, it randomly selects one of these quotes and prints it to the screen.
//The idea behind this is that it will give the user a little bit of motivation regarded to actually keeping a journal in the first place.
//This is a thing I personally struggle with, so this feature was meant for people like me, who struggle to start a consistent journal.

using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new();
        Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////////");
        Console.WriteLine("Welcome to your personal Journaling Program. Programmed by Michael Scoville, your fearless Leader.");
        Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////////////");

        bool run = true;
        while (run)
        {
            Console.WriteLine();
            Console.WriteLine("1: Write a new journal entry");
            Console.WriteLine("2: Display previous entries");
            Console.WriteLine("3: Save");
            Console.WriteLine("4: Load");
            Console.WriteLine("5: Quit");

            Console.WriteLine();
            Console.WriteLine("6: Motivate me!");
            Console.WriteLine();

            Console.Write("Please select a number: ");
            string userSelect = Console.ReadLine();

            if (userSelect == "1")
            {
                journal.Write();
            }

            else if (userSelect == "2")
            {
                journal.Display();
            }

            else if (userSelect == "3")
            {
                journal.Save();
            }

            else if (userSelect == "4")
            {
                journal.Load();
            }

            else if (userSelect == "5")
            {
                run = false;
            }

            else if (userSelect == "6")
            {
                journal.Motivate();
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("PLEASE select a number (from those listed above): ");
            }
        }
    }
}