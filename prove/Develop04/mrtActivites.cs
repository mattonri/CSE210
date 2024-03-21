
public class mrtActivities
{
    protected int _durTime;
    private DateTime _startTime;
    private DateTime _endTime;
    private string _type;
    private string _description;

    public mrtActivities(string p_type, string p_description)
    {
        _type = p_type;
        _description = p_description;
    }
    public void mrtIntro()
    {
        Console.WriteLine($"  ---  Welcome to the {_type} activity!  ---  ");
        Console.WriteLine(_description);
        Console.Write("How long would you like to spend on this activity? (in seconds): ");
        _durTime = int.Parse(Console.ReadLine());
        _startTime = DateTime.Now;
    }
    public void mrtEnding()
    {
        _endTime = DateTime.Now;
        TimeSpan _timeDiff = _endTime - _startTime;
        double _actualDur = _timeDiff.TotalSeconds;
        Console.WriteLine($" ---  You just spent exactly {Math.Round(_actualDur)} seconds on the {_type} activity!  ---  ");
        Thread.Sleep(5000);
    }
    public void mrtSpinnerAnimation(int p_seconds)
    {
        char[] _animationFrames = {'|', '\\', '-', '/'};
        for(int i = 0; i < p_seconds * 2; i++)
        {
            Console.Write(_animationFrames[i%4]);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void mrtCounterAnimation(int p_seconds)
    {
        for(int i = 0; i < p_seconds; i++)
        {
            Console.Write(p_seconds - i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}