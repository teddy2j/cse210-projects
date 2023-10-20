public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }
    public override void RecordEvent()
    {
        _amountCompleted += 1;
        Console.WriteLine($"Congratulations! You have earned {_points} points! ");
        if (_amountCompleted == _target)     
        {
            Console.WriteLine($"Aditionally, you get {_bonus} for completing this goal {_target} times!");
        }
    }
    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailsString()
    {
        string mark = " ";
        if (IsComplete() == true)
        {
            mark = "X";
        }
        return $"[{mark}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target} ";

    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }

    public void SetAmount(int amount)
    {
        _amountCompleted = amount;
    }

    public override int GetNumberToAdd()
    {
        int points = _points;
        if (_amountCompleted == _target)
        {
            points += _bonus;
        }
        return points;
    }

}