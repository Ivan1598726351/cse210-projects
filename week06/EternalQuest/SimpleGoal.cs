public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete)
    :base(name, description, points)
    {
        _isComplete=isComplete;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override int RecordEvent()
    {
        if (_isComplete==false)
        {
            _isComplete=true;
            return GetPoints();
        }

        return 0;
        
        
    }

    public override string GetStringRepresentation()
    {
        return "SimpleGoal|"+GetName()+"|"+GetDescription()+"|"+GetPoints()+"|"+IsComplete();
    }

    public override string GetDetailsString()
    {
        string checkBox="[ ]";
        if (_isComplete==true)
        {
            checkBox="[X]";
        }

        return checkBox+" "+GetName()+" "+"("+GetDescription()+")";
    }

}