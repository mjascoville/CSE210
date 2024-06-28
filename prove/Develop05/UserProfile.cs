using System.IO;

class UserProfile
{
    private List<Goal> _goals;
    private int _points;

    public UserProfile()
    {
        _points = 0;
        _goals = new();
    }

    public void Display()
    {
        int level = _points / 1000 + 1;
        Console.WriteLine($"You have {_points} points.");
        Console.WriteLine($"You are level {level}.");
    }

    public void ListGoals()
    {
        int counter = 1;
        foreach (Goal goal in _goals)
        {
            Console.Write($"{counter}. ");
            goal.Display();
            counter += 1;
        }
    }

    public void RecordGoal()
    {
        ListGoals();
        Console.Write("Select the goal you'd like to mark as complete: ");
        string choice = Console.ReadLine();
        int goalID = 0;

        if (!int.TryParse(choice, out goalID) && (goalID < 1 || goalID > _goals.Count))
        {
            Console.WriteLine("That isn't a valid option.");
            return;
        }

        _points += _goals[goalID-1].Record();
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select which type of goal you'd like to set: ");
        Console.WriteLine("1: Simple Goal");
        Console.WriteLine("2: Eternal Goal");
        Console.WriteLine("3: Checklist Goal");
        Console.WriteLine();
        Console.Write(": ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("What will the name of this goal be?");
            string description = Console.ReadLine();
            Console.WriteLine("How many points is this goal worth?");
            string strPoints = Console.ReadLine();
            int points = 0;

            if (!int.TryParse(strPoints, out points))
            {
                Console.WriteLine("This is not a valid value.");
                return;
            }

            SimpleGoal goal = new(description, points);
            _goals.Add(goal);
        }

        else if (choice == "2")
        {
            Console.WriteLine("What will the name of this goal be?");
            string description = Console.ReadLine();
            Console.WriteLine("How many points is this goal worth?");
            string strPoints = Console.ReadLine();
            int points = 0;

            if (!int.TryParse(strPoints, out points))
            {
                Console.WriteLine("This is not a valid value.");
                return;
            }

            EternalGoal goal = new(description, points);
            _goals.Add(goal);
        }

        else if (choice == "3")
        {
            Console.WriteLine("What will the name of this goal be?");
            string description = Console.ReadLine();
            Console.WriteLine("How many points is this goal worth?");
            string strPoints = Console.ReadLine();
            int points = 0;

            if (!int.TryParse(strPoints, out points))
            {
                Console.WriteLine("This is not a valid value.");
                return;
            }

            Console.WriteLine("How many times do you want to complete this goal in order to get a bonus?");
            string strCheck = Console.ReadLine();
            int check = 0;

            if (!int.TryParse(strCheck, out check))
            {
                Console.WriteLine("This is not a valid value.");
                return;
            }
            
            Console.WriteLine("How many points will the bonus be worth?");
            string strBonus = Console.ReadLine();
            int bonus = 0;

            if (!int.TryParse(strBonus, out bonus))
            {
                Console.WriteLine("This is not a valid value.");
                return;
            }

            ChecklistGoal goal = new(description, bonus, points, check);
            _goals.Add(goal);
        }
        
        else
        {
            Console.WriteLine("This is not a valid option.");
        }
    }

    public void Save()
    {
        Console.Write("Enter a name for this file: ");
        string fileName = Console.ReadLine();

        using (StreamWriter sw = File.CreateText(fileName))
        {
            sw.WriteLine(_points);
            foreach (Goal goal in _goals)
            {
                sw.WriteLine(goal.MakeString());
            }
        }
    }

    public void Load()
    {
        Console.Write("Enter the name of the file: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("This file does not exist!");
            return;
        }

        _goals.Clear();
        using (StreamReader sr = File.OpenText(fileName))
        {
            string strPoints = sr.ReadLine();
            if (!int.TryParse(strPoints, out _points))
            {
                Console.WriteLine("Failed to load file!");
                return;
            }

            while (sr.Peek() >= 0)
            {
                string[] line = sr.ReadLine().Split("|");

                if (line[0] == "SimpleGoal")
                {
                    string description = line[1];
                    strPoints = line[2];
                    int points = 0;

                    if (!int.TryParse(strPoints, out points))
                    {
                        Console.WriteLine("Failed to load file!");
                        return;
                    }

                    string strIsComplete = line[3];
                    bool isComplete = false;
                    if (!bool.TryParse(strIsComplete, out isComplete))
                    {
                        Console.WriteLine("Failed to load file!");
                        return;
                    }

                    SimpleGoal goal = new(description, points, isComplete);
                    _goals.Add(goal);
                }

                if (line[0] == "EternalGoal")
                {
                    string description = line[1];
                    strPoints = line[2];
                    int points = 0;

                    if (!int.TryParse(strPoints, out points))
                    {
                        Console.WriteLine("Failed to load file!");
                        return;
                    }

                    string strCount = line[3];
                    int count = 0;
                    if (!int.TryParse(strCount, out count))
                    {
                        Console.WriteLine("Failed to load file!");
                        return;
                    }

                    EternalGoal goal = new(description, points, count);
                    _goals.Add(goal);
                }

                else if (line[0] == "ChecklistGoal")
                {
                    string description = line[1];
                    string strBonus = line[2];
                    int bonus = 0;

                    if (!int.TryParse(strBonus, out bonus))
                    {
                        Console.WriteLine("This is not a valid value.");
                        return;
                    }

                    strPoints = line[3];
                    int points = 0;

                    if (!int.TryParse(strPoints, out points))
                    {
                        Console.WriteLine("Failed to load file!");
                        return;
                    }

                    string strTimes = line[4];
                    int times = 0;

                    if (!int.TryParse(strTimes, out times))
                    {
                        Console.WriteLine("This is not a valid value.");
                        return;
                    }
            
                    string strCheck = line[5];
                    int check = 0;

                    if (!int.TryParse(strCheck, out check))
                    {
                        Console.WriteLine("This is not a valid value.");
                        return;
                    }

                    ChecklistGoal goal = new(description, bonus, points, times, check);
                    _goals.Add(goal);
                }
            }
        }
    }
}       