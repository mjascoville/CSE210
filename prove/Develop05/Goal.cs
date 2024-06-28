abstract class Goal
{
    protected string _description;
    protected int _value;

    public Goal(string description, int value)
    {
        _description = description;
        _value = value;
    }
    
    public abstract int Record();
    public abstract void Display();
    public abstract string MakeString();
}

