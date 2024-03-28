
public class mrtEternal : mrtGoal
{
    public mrtEternal(string p_name, string p_description, int p_points) : base(p_name, p_description, p_points)
    {

    }



    public override string mrtToCSV()
    {
        string _constructedString = $"EternalGoal:{_name},{_description},{_points}";
        return _constructedString;
    }
    public override string mrtToString()
    {

        string _constructedString = $"[*] {_name} ({_description})";
        return _constructedString;
    }
    public override int mrtRecordEvent()
    {
        int _pointGain = _points;
        return _pointGain;
    }
    public override bool mrtIsCompleted()
    {
        return false;
    }
}