

public class mrtReflection : mrtActivities
{

    public mrtReflection(string p_type="Relfections", string p_description="This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") : base(p_type, p_description)
    {

    }

    public void mrtMiddle()
    {
        Console.WriteLine(_RandomPrompt());
        Console.WriteLine("Now think on that experience for just a few seconds");
        mrtCounterAnimation(3);
        double _durTimeFloat = _durTime;
        double _repetitions = Math.Ceiling((_durTimeFloat - 3)/5);
        for(int i = 0; i < _repetitions; i++)
        {
            Console.WriteLine($"{i+1}: {_RandomQuestion()}");
            mrtSpinnerAnimation(5);
        }
        Console.WriteLine("Hopefully your reflections were edifying and constructive!");
    }
    private string _RandomPrompt()
    {
        Random _randomGenerator = new Random();
        int _randomSelection = _randomGenerator.Next(0,4);
        string[] _prompts = {"Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."};
        return _prompts[_randomSelection];
    }

    private string _RandomQuestion()
    {
        Random _randomGenerator = new Random();
        int _randomSelection = _randomGenerator.Next(0,9);
        string[] _questions = {"Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"};
        return _questions[_randomSelection];
    }
    public void mrtRun()
    {
        mrtIntro();
        mrtMiddle();
        mrtEnding();
    }
}