using System.IO.Enumeration;

public class GoalManager
{
    private int _score;
    private List<Goal> _goals = new List<Goal>();

    public GoalManager()
    {
        _score=0;
        _goals=new List<Goal>();
    }

    public List<Goal> GetListOfGoals()
    {
        return _goals;
    }
    public string DisplayPlayerInfo()
    {
        return $"You have {_score} points";
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoalNames()
    {
        int listIndex= 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{listIndex}. {goal.GetName()}");
            listIndex=listIndex+1;   
        }
    }

    public void ListGoalDetails()
    {
        int listIndex= 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{listIndex}. {goal.GetDetailsString()}");
            listIndex=listIndex+1;   
        }
    }

    public int RecordEventGoalManager(Goal goal)
    {
        _score=_score+goal.RecordEvent();
        return _score;
    }

    public void SaveGoals()
    {
        Console.Write("Choose file name that you want to save your goals under ");
        string filename=Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

    }

    public void LoadGoals()
    {
        Console.Write("Select the file you want to read ");
        string filename=Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            if (parts[0]=="SimpleGoal")
            {
                SimpleGoal sg = new SimpleGoal(parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4]));
                _goals.Add(sg);
            }
            else if (parts[0]=="EternalGoal")
            {
                EternalGoal eg = new EternalGoal(parts[1],parts[2],int.Parse(parts[3]));
                _goals.Add(eg);
            }
            else if (parts[0]=="ChecklistGoal")
            {
                ChecklistGoal clg = new ChecklistGoal(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[4]),int.Parse(parts[5]),int.Parse(parts[6]));
                _goals.Add(clg);
            }
        }




    }

}