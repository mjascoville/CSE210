class ListingActivity : Activity
{
	private string[] _prompts = [
		"Who are your personal heroes?",
		"List your favorite fictional characters.",
		"How many reptiles can you think of?",
		"What are your favorite foods?",
		"How many colors can you think of?",
	];
	private int _responses = 0;

	public ListingActivity() : base("Listing Activity", "In this activity you will write as many answers to\nthe prompt as you can think of.") {}

	public void PerformActivity()
	{
		base.StartActivity();
		Console.WriteLine($"\nPrompt: {PickItem(_prompts)}");
        Console.WriteLine();
		Console.WriteLine("The activity will begin shortly.");
		base.Wait(5);

		base.StartTimer();
		while (!base.IsTimerExpired())
		{
			Console.Write("> ");
			Console.ReadLine();
			_responses += 1;
		}

		Console.WriteLine($"You wrote {_responses} responses.");
		base.EndActivity();
	}
}