public class CyclingActivity : Activity
{
    public double _speed;

    public CyclingActivity(int duration, double speed)
    :base(duration)
    {
        _speed=speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        return (_speed*GetDuration())/60;
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
        return $"{dateFormated}, cycling ({duration} min): Distance {GetDistance():F2}km, Speed {speed}kph, Pace {pace:F2} minutes per km";
    }


}