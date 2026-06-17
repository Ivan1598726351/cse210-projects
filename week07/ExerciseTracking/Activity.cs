public abstract class Activity
{
    private int _duration;
    private DateTime _date;
    
    public abstract string GetSummary();

    public abstract double GetSpeed();

    public abstract double GetDistance();

    public abstract double GetPace();

    public Activity(int duration)
    {
        _duration=duration;
        _date= DateTime.Today;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public int GetDuration()
    {
        return _duration;
    }
//DateTime today = DateTime.Today;

//Console.WriteLine(today.ToString("MMMM d, yyyy"));

}