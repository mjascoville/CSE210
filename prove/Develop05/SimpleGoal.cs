class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string description, int value) : base(description, value)
    {
        _isComplete = false;   
    }

    public SimpleGoal(string description, int value, bool isComplete) : base(description, value)
    {
        _isComplete = isComplete;   
    }

    public override int Record()
    {
        if (_isComplete) 
        {
            return 0;
        }

        _isComplete = true;
        return _value;
    }

    public override void Display()
    {
        if (_isComplete)
        {
            Console.WriteLine($"[x] {_description}");
        }

        else
        {
            Console.WriteLine($"[ ] {_description}");
        }

    }

    public override string MakeString()
    {
        string goal = $"SimpleGoal|{_description}|{_value}|{_isComplete}";
        return goal;
    }
}