public class WrittingAssignemnt : Assignment
{
    private string _title;

    public WrittingAssignemnt(string studentName, string topic, string title)
    : base(studentName, topic)
    {
        _title=title;
    }

    public string GetWrittingInformation()
    {
        return $"{_title}";
    }
}