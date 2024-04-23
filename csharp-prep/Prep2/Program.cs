using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percentage grade did you earn? ");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);

        if (grade >=90)
        {
            Console.WriteLine("You have earned an A!");
        }
        else if (grade >=80)
        {
            Console.WriteLine("You have earned a B!");
        }
        else if (grade >=70)
        {
            Console.WriteLine("You have earned a C.");
        }
        else if (grade >=60)
        {
            Console.WriteLine("You have earned a D.");
        }
        else 
        {
            Console.WriteLine("You have earned an F.");
        }

        if (grade >= 70)
        {
            Console.Write("Great job! You have passed the class.");
        }
        else 
        {
            Console.Write("I'm so sorry! You haven't passed this class.");
        }


    }
}