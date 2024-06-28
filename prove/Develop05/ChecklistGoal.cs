using System.ComponentModel.DataAnnotations;

class ChecklistGoal : Goal
{
    private int _stepValue;
    private int _step;
    private int _totalSteps;

    public ChecklistGoal(string description, int value, int stepValue, int totalSteps) : base(description, value)
    {
        _stepValue = stepValue;
        _step = 0;
        _totalSteps = totalSteps;
    }

    public ChecklistGoal(string description, int value, int stepValue, int step, int totalSteps) : base(description, value)
    {
        _stepValue = stepValue;
        _step = step;
        _totalSteps = totalSteps;
    }

    public override int Record()
    {
        if (_step >= _totalSteps)
        {
            return 0;
        }

        int points = _stepValue;
        _step += 1;
     
        if (_step == _totalSteps)
        {
            points += _value;
        }

        return points;
    }

    public override void Display()
    {
        if (_step < _totalSteps)
        {
            Console.WriteLine($"[ ] {_description} {_step}/{_totalSteps}");
        }   

        else
        {
            Console.WriteLine($"[x] {_description} {_step}/{_totalSteps}");
        }
    }

    public override string MakeString()
    {
        string goal = $"ChecklistGoal|{_description}|{_value}|{_stepValue}|{_step}|{_totalSteps}";
        return goal;
    }
}