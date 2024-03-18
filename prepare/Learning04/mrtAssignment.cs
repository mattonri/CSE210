

public class mrtAssignment
{

    private string _studentName;
    private string _topic;

    public mrtAssignment(string p_studentName, string p_topic)
    {
        _studentName = p_studentName;
        _topic = p_topic;
    }

    public string mrtGetSummary()
    {
        string output = $"Student Name: {_studentName}\nTopic: {_topic}";
        return output;
    }
}