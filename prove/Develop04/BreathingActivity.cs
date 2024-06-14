using System.Threading;

class BreathingActivity : Activity
{
	public BreathingActivity() : base("Breathing Activty", "In this activity you will follow a guided breathing exercise. The goal is to focus on taking long and controlled breaths.") {}

	public void PerformActivity()
	{
		base.StartActivity();
		Console.WriteLine("The activity will begin shortly.");
		base.Wait(5);

		base.StartTimer();
		while (!base.IsTimerExpired())
		{
			Console.Write("Breathe in... ");
			CountDown(6);
			Console.WriteLine();
			Console.Write("Breathe out... ");
			CountDown(4);
			Console.WriteLine();
		}

		base.EndActivity();
	}

	private void CountDown(int duration)
	{
		while (duration > 0)
		{
			Console.Write($"{duration}");
			Thread.Sleep(1000);
			Console.Write("\b");
			duration -= 1;
		}
		Console.Write(" ");
	}
}