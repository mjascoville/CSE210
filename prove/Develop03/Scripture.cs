using System.Security.Cryptography;

class Scripture
{
	private List<Word> _words;

	private Reference _reference;

	private Random _random;

	public Scripture(Reference reference, string text)
	{
		_reference = reference;
		_random = new();
		_words = [];

		foreach (string word in text.Split(" "))
		{
			_words.Add(new Word(word));
		}
	}

	public void Display()
	{
		_reference.Display();
		foreach (Word word in _words)
		{
			Console.Write($"{word.Render()} ");
		}
		Console.WriteLine();
	}

	public void HideWords()
	{
		int wordsHidden = 0; 

		while (wordsHidden < 3 && !AllHidden())
		{
			int rand = _random.Next(_words.Count());
			if (!_words[rand].IsHidden())
			{
				_words[rand].Hide();
				wordsHidden += 1;
			}
		}
	}
	public bool AllHidden()
	{
		foreach (Word word in _words)
		{
			if (word.IsHidden() == false)
			{
				return false;
			}
		}
		return true;
	}
}