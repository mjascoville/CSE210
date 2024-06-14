using System;
using System.Threading;

class Activity
{
	private string _name;
	private string _description;
	private int _duration;
	private DateTime _startTime;
	private Random _rand = new();

	public Activity(string name, string description)
	{
		_name = name;
		_description = description;
	}

	public void StartActivity()
	{
		Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name}.");
		Console.WriteLine(_description);
		Console.WriteLine();

		int duration = 0;
		while (duration <= 0)
		{
			Console.Write("How long would you like this activity to last (seconds)? ");
			string rawDuration = Console.ReadLine();

			if (!int.TryParse(rawDuration, out duration))
			{
				Console.WriteLine("That's impossible!");
			}
		}

		_duration = duration;
	}

	public void StartTimer()
	{
		_startTime = DateTime.Now;
	}

	public bool IsTimerExpired()
	{
		if (DateTime.Now >= _startTime.AddSeconds((double) _duration))
		{
			return true;
		}

		return false;
	}

	public void EndActivity()
	{
		Console.WriteLine($"Well done. You accomplished {_duration} seconds of {_name}.");
	}

	public void Wait(int duration)
	{
		string eraser = "\b\b\b\b\b\b\b\b\b\b\b\b";
		string[] loadingBar = [
			"....",
			"*...",
			"~*..",
			".~*.",
			"..~*",
            "...~",
            "....",
            "...*",
            "..*~",
            ".*~.",
            "*~..",
            "~...",
		];
		DateTime endTime = DateTime.Now.AddSeconds((double) duration);

		int index = 0;
		while (DateTime.Now < endTime)
		{
			Console.Write(loadingBar[index]);
			index += 1;
			if (index >= loadingBar.Count())
			{
				index = 0;
			}

			Thread.Sleep(500);
			Console.Write(eraser);
		}

		Console.Write("    ");
		Console.Write(eraser);
	}

	protected string PickItem(string[] items)
	{
		int index = _rand.Next(items.Count());
		return items[index];
	}
}