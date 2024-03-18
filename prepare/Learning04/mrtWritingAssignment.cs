

public class mrtWritingAssignment : mrtAssignment
{
    private string _title;

    public mrtWritingAssignment(string p_title, string p_studentName, string p_topic) : base(p_studentName, p_topic)
    {
        _title = p_title;
    }
    public string mrtGetWritingInformation()
    {
        string _output = $"{mrtGetSummary()}\nTitle: {_title}";
        return _output;
    }

}