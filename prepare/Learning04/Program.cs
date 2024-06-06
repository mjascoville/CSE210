using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Michael Scoville", "E=MC^2");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Tom Thumb", "Decimals", "7.3", "8 and 9");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Frederick Douglas", "American History", "The Grapes of Wrath");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}