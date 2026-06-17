public class SwimmingActivity : Activity
{
    private int _numberOfLaps;

    public SwimmingActivity(int duration, int numberOfLaps)
    :base(duration)
    {
        _numberOfLaps=numberOfLaps;
    }

    public int GetNumberOfLaps()
    {
        return _numberOfLaps;
    }
    public override double GetDistance()
    {
        return 0.05*_numberOfLaps;
    }

    public override double GetSpeed()
    {
        return 60*GetDistance()/GetDuration();
    }

    public override double GetPace()
    {
        return 1.0*GetDuration()/GetDistance();
    }

    public override string GetSummary()
    {
        DateTime date = GetDate();
        string dateFormated = date.ToString("MMMM d, yyyy");
        double speed = GetSpeed();
        double pace = GetPace();
        int duration = GetDuration();
        return $"{dateFormated}, swimming ({duration} min): Distance {GetDistance():F2}km, Speed {speed:F2}kph, Pace {pace:F2} minutes per km";
    }


}