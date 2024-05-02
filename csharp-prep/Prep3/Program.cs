using System;

class Program
{
    static void Main(string[] args)
   {
        Random randomGenerator = new Random();
        int magicNumberMS = randomGenerator.Next(1, 101);

        int guessMS = -1;

        while (guessMS != magicNumberMS)
        {
            Console.Write("What is your guess? ");
            guessMS = int.Parse(Console.ReadLine());

            if (magicNumberMS > guessMS)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumberMS < guessMS)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}