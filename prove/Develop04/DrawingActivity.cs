class DrawingActivity : Activity
{
    private string[] _prompts = [
        "Draw something bold.",
        "Draw something that makes you feel happy.",
        "Draw something that scares you.",
        "Draw something that has three components in it.",
        "Draw something that reminds you of home.",
        "Draw something you'd like to see happen today.",
    ];

    public DrawingActivity() : base("Drawing Activity", "In this activity you will need something to draw with. You will recieve a prompt, and you may draw for as long as the timer is set.") {}

        public void PerformActivity()
    {
        base.StartActivity();
		Console.WriteLine($"\nPrompt: {PickItem(_prompts)}");
        Console.WriteLine();
		Console.WriteLine("The activity will begin shortly. Please gather your drawing materials.");
		base.Wait(10);

        Console.WriteLine("Begin drawing.");

        base.StartTimer();
        while (!base.IsTimerExpired())
        {
            base.Wait(5);
        }

        base.EndActivity();
    }
}

