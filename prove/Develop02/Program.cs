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