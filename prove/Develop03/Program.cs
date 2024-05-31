// I exceeded requirements by adding a landing menu for the user. When the program starts, you will be prompted to choose which scripture to memorize from a list.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new("Psalm", 32, 6, 7);
        Reference reference2 = new("Psalm", 32, 1, 2);

        string actualVerse = "For this shall every one that is godly pray unto thee in a time when thou mayest be found: surely in the floods of great waters they shall not come nigh unto him. Thou art my hiding place; thou shalt preserve me from trouble; thou shalt compass me about with songs of deliverance. Selah.";
        string actualVerse2 = "Blessed is he whose transgression is forgiven, whose sin is covered. Blessed is the man unto whom the Lord imputeth not iniquity, and in whose spirit there is no guile.";

        Console.WriteLine("*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*");
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*");
        Console.WriteLine();
        Console.WriteLine("Please choose the number of which of the verses you'd like to memorize: ");
        Console.Write("1: ");
        reference2.Display();
        Console.Write("2: ");
        reference.Display();
        string choice1 = Console.ReadLine();
        
        Scripture scripture;

        if (choice1 == "1")
        {
            scripture = new(reference2, actualVerse2);
        }
        else
        {
            scripture = new(reference, actualVerse);
        }

        bool running = true;

        while (running)
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("Press Enter to memorize, or type quit.");
            string choice2 = Console.ReadLine();

            if (choice2 == "quit" || scripture.AllHidden())
            {
                running = false;
            }

            scripture.HideWords();
        }
    }
}