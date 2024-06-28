//To exceed the base requirements, I decided to implement a basic "Leveling" system. Everytime the user gains 1000 points, they will level up, and this will be displayed on the main menu below your points.

using System;

class Program
{
    static void Main(string[] args)
    {
        UserProfile user = new();

        Console.WriteLine("+~~~~~~~~~~~~~~~~~~~~~~~~+");
        Console.WriteLine("+Welcome to the Goal App!+");
        Console.WriteLine("+~~~~~~~~~~~~~~~~~~~~~~~~+");

        bool running = true;
        while (running)
        {
            user.Display();

            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1: Create New Goal");
            Console.WriteLine("2: List Goals");
            Console.WriteLine("3: Save Goals");
            Console.WriteLine("4: Load Goals");
            Console.WriteLine("5: Complete a Goal");
            Console.WriteLine("6: Quit");
            Console.WriteLine();
            Console.Write("Select an option from the list above: ");
            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                user.CreateGoal();
            }

            else if (choice == "2")
            {
                user.ListGoals();
            }

            else if (choice == "3")
            {
                user.Save();
            }

            else if (choice == "4")
            {
                user.Load();
            }

            else if (choice == "5")
            {
                user.RecordGoal();
            }
            
            else if (choice == "6")
            {
                running = false;
            }
            
            else
            {
                Console.WriteLine("That's not an option!");
            }
        }
    }
}