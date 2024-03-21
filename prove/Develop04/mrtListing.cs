public class mrtListing : mrtActivities
{

    public mrtListing(string p_type="Listing", string p_description="In this activity, you will follow the program and list out a number of items.") : base(p_type, p_description)
    {

    }

    public void mrtMiddle()
    {
        Console.WriteLine(_RandomPrompt());
        Console.WriteLine("Now think of that for just a few seconds");
        mrtSpinnerAnimation(3);
        List<string> _entries = new List<string>();
        DateTime _beginningTime = DateTime.Now;
        DateTime _currentTime = DateTime.Now;
        TimeSpan _timeDiff =  _currentTime - _beginningTime;
        double _actualDur = _timeDiff.TotalSeconds - 3;
        double _durTimeFloat = _durTime;
        while(_durTimeFloat > _actualDur)
        {
            Console.Write($"{_entries.Count()+1}: ");
            _entries.Add(Console.ReadLine());
            _currentTime = DateTime.Now;
            _timeDiff =  _currentTime - _beginningTime;
            _actualDur = _timeDiff.TotalSeconds;
        }
        Console.WriteLine($"You wrote {_entries.Count()} items!");
    }
    private string _RandomPrompt()
    {
        Random _randomGenerator = new Random();
        int _randomSelection = _randomGenerator.Next(0,5);
        string[] _prompts = {"Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"};
        return _prompts[_randomSelection];
    }
    public void mrtRun()
    {
        mrtIntro();
        mrtMiddle();
        mrtEnding();
    }
}