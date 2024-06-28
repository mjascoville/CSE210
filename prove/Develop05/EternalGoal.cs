class EternalGoal : Goal
{
    private int _count;

    public EternalGoal(string description, int value) : base(description, value)
    {
        _count = 0; 
    }

    public EternalGoal(string description, int value, int count) : base(description, value)
    {
        _count = count; 
    }

    public override int Record()
    {
        _count += 1;
        return _value;   
    }

    public override void Display()
    {
        Console.WriteLine($"{_description}: {_count}");
    }

    public override string MakeString()
    {
        string goal = $"EternalGoal|{_description}|{_value}|{_count}";
        return goal;
    }
}