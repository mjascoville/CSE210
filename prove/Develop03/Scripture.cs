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
}