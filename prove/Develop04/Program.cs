//To exceed the requirements of this assignment, I decided to create a new activity. There is now a Drawing Activity that gives the user a prompt, and then the user
//draws for as long as the timer is set. Sometimes we just need an idea to get started with art, and that is what this activity encourages.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*~~~~~~~~~~~~~~~~~~~~~~~~~~~~*");
        Console.WriteLine("Welcome to the mindfulness app!");
        Console.WriteLine("*~~~~~~~~~~~~~~~~~~~~~~~~~~~~*");
        Console.WriteLine("");
        Console.WriteLine("Please select a number from the options below.");
        Console.WriteLine("");

        bool running = true;
        while (running)
        {
            Console.WriteLine("1: Breathing Activity");
            Console.WriteLine("2: Reflection Activity");
            Console.WriteLine("3: Listing Activity");
            Console.WriteLine("4: Drawing Activity");
            Console.WriteLine("5: Quit");

            Console.Write(": ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                BreathingActivity activity = new();
                activity.PerformActivity();
            }
            
            else if (input == "2")
            {
                ReflectionActivity activity = new();
                activity.PerformActivity();
            }

             else if (input == "3")
            {
                ListingActivity activity = new();
                activity.PerformActivity();
            }

            else if (input == "4")
            {
                DrawingActivity activity = new();
                activity.PerformActivity();
            }

            else if (input == "5")
            {
                running = false;
            }

            else
            {
                Console.WriteLine("That's not an option!\n");
            }
        }
    }
}