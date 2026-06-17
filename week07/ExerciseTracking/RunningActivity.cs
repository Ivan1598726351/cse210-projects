using System.Diagnostics;

public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(int duration, double distance)
    :base(duration)
    {
        _distance=distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return 60.0*_distance/GetDuration() ;
    }

    public override double GetPace()
    {
        return GetDuration()/_distance;
    }

    public override string GetSummary()
    {
        DateTime date = GetDate();
        string dateFormated = date.ToString("MMMM d, yyyy");
        double speed = GetSpeed();
        double pace = GetPace();
        int duration = GetDuration();
        return $"{dateFormated}, running ({duration} min): Distance {GetDistance()}km, Speed {speed:F2}kph, Pace {pace:F2} minutes per km";
    }

    
}