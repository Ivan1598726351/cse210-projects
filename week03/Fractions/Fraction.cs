using System.IO.Pipelines;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top=1;
        _bottom=1;
    }

    public Fraction(int top)
    {
        _top=top;
        _bottom=1;
    }

    public Fraction(int top, int bottom)
    {
        _top=top;
        _bottom=bottom;
    }


    public int GetTop()
    {
        return _top;
    }

    public void setTop (int top)
    {
        _top=top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void setBottom (int bottom)
    {
        _bottom=bottom;
    }

    public string GetFractionString(int top, int bottom)
    {
        string topNumber=top.ToString();
        string bottomNumber=bottom.ToString();
        return topNumber + "/" + bottomNumber;
        

    }


    public double GetDecimalNumber(int top, int bottom)
    {
        double Res= (double) top/bottom;
        return Res;
    }

}