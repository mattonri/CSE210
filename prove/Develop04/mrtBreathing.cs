
public class mrtBreathing : mrtActivities
{

    public mrtBreathing(string p_type="Breathing", string p_description="In this activity, you will follow the program as it leads you through a breathing exersise. Each cycle takes 15 seconds.") : base(p_type, p_description)
    {

    }

    public void mrtMiddle()
    {
        double _durTimeFloat = _durTime;
        double _repetitions = Math.Ceiling(_durTimeFloat/15);
        for(int i = 0; i < _repetitions; i++)
        {
            Console.Write("Breathe in: ");
            mrtCounterAnimation(4);
            Console.WriteLine();
            Console.Write("Hold: ");
            mrtCounterAnimation(5);
            Console.WriteLine();
            Console.Write("Breathe out: ");
            mrtCounterAnimation(6);
            Console.WriteLine();
        }
        Console.WriteLine("All finished. Well done!");
        Thread.Sleep(500);

    }
    public void mrtRun()
    {
        mrtIntro();
        mrtMiddle();
        mrtEnding();
    }
}