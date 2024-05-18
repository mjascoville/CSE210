using System.IO;
public class Journal

{
    public List<Entry> _entries = [];
    public PromptGen _prompGen = new();
    
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"{entry._date}");
            Console.WriteLine($"{entry._promp}");
            Console.WriteLine();
            Console.WriteLine($"{entry._response}");
            Console.WriteLine();
        } 
    }

    public void Write()
    {
        string prompStore = _prompGen.GetPrompt();
        Entry neoEntry = new();
        neoEntry._promp = prompStore;
        neoEntry._date = DateTime.Now.ToString(); 

        Console.WriteLine($"{prompStore}");
        Console.Write(": ");
        neoEntry._response = Console.ReadLine();
        _entries.Add(neoEntry);
    }

    public void Save()
    {
        string savedEntry = "";

        foreach (Entry entry in _entries)
        {
            savedEntry += entry._date + "\n";
            savedEntry += entry._promp + "\n";
            savedEntry += entry._response + "\n";
        }
        Console.Write("Please provide me with a name for your save file: ");
        string saveName = Console.ReadLine();
        File.WriteAllText(saveName, savedEntry);
    }

    public void Load()
    {
        Console.Write("Please provide me with the name of your save file: ");
        string loadName = Console.ReadLine();

        if (!File.Exists(loadName))
        {
            Console.WriteLine("Oops! That file doesn't exist.");
            return;
        }

        string[] lines = File.ReadAllLines(loadName);

        _entries.Clear();

        for (int i = 0; i < lines.Count(); i += 3)
        {
            Entry loadEntry = new();
            loadEntry._date = lines[i];
            loadEntry._promp = lines[i + 1];
            loadEntry._response = lines[i + 2];

            _entries.Add(loadEntry);
        }
    }

    public void Motivate()
    {
        string quote = _prompGen.GetMotivation();
        Console.WriteLine(quote);
    }
}
