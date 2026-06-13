public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;

    private int _bonus;

     public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus)
    :base(name, description, points)
    {
        _amountCompleted=amountCompleted;
        _target=target;
        _bonus=bonus;
    }

    public int GetBonus()
    {
        return _bonus;
    }
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }
    public override int RecordEvent()
    {
        _amountCompleted=_amountCompleted+1;
        if (_amountCompleted<_target)
        {
            
            return GetPoints();
            
        }
        else if (_amountCompleted==_target)
        {
            return GetPoints()+GetBonus();
        }
        return 0;
        
    }

    public override bool IsComplete()
    {
        if (_amountCompleted>=_target)
        {
            return true;
        }

        return false;
    }

    public override string GetStringRepresentation()
    {
        return "ChecklistGoal|"+GetName()+"|"+GetDescription()+"|"+GetPoints()+"|"+GetAmountCompleted()+"|"+GetTarget()+"|"+GetBonus()+"|"+IsComplete();
    }

    public override string GetDetailsString()
    {
        string checkBox="[ ]";
        if (IsComplete()==true)
        {
            checkBox="[X]";
        }

        return checkBox+" "+GetName()+" "+"("+GetDescription()+")"+" "+GetAmountCompleted()+"/"+GetTarget();
    }

}