class Reference
{
	private string _book;

	private int _chapter;

	private int _startVerse;

	private int _endVerse;

	public Reference (string b, int c, int sv, int ev)
	{
		_book = b;
		_chapter = c;
		_startVerse = sv;
		_endVerse = ev;
	}

	public Reference (string b, int c, int v)
	{
		_book = b;
		_chapter = c;
		_startVerse = v;
		_endVerse = v;
	}

	public void Display()
	{
		Console.WriteLine($"{_book} {_chapter}: {_startVerse}-{_endVerse}");
	}
}