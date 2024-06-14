class ReflectionActivity : Activity 
{
    private string[] _prompts = [
        "Think of a time when you stood up for a belief you hold.",
        "Think of a time when you had to do something very difficult.",
        "Think of a time when you helped someone.",
        "Think of a time when you did something truly selfless,",
    ];

    private string[] _questions = [
        "How was this experience meaningful to you?",
        "Have you done something like this since?",
        "How did you get started?",
        "How did you feel when it was all over?",
        "What made this time unique compared to other times?",
        "What is your favorite thing about this experience?",
        "What can you learn from this that can be applied to other situations?",
        "What did you learn about yourself from this?",
        "How will you keep this experience in mind in the future?",
    ];

    public ReflectionActivity() : base("Reflection Activity", "In this activity you will be reflecting on some prompts and answering guided questions about them."){}

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
            Console.WriteLine(PickItem(_questions));
            base.Wait(5);
        }

        base.EndActivity();
    }
}