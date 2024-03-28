

public class mrtSimple : mrtGoal
{
    private bool _completed;

    public mrtSimple(string p_name, string p_description, int p_points, bool p_completed=false) : base(p_name, p_description, p_points)
    {
        _completed = p_completed;
    }



    public override string mrtToCSV()
    {
        string _constructedString = $"SimpleGoal:{_name},{_description},{_points},{_completed}";
        return _constructedString;
    }
    public override string mrtToString()
    {
        char _check = ' ';
        if(_completed)
        {
            _check='X';
        }
        else
        {
            _check=' ';
        }
        string _constructedString = $"[{_check}] {_name} ({_description})";
        return _constructedString;
    }
    public override int mrtRecordEvent()
    {
        int _pointGain;
        if(_completed)
        {
            _pointGain = 0;
        }
        else
        {
            _pointGain = _points;
        }
        _completed = true;
        return _pointGain;
    }
    public override bool mrtIsCompleted()
    {
        bool _isCompleted = _completed;
        return _isCompleted;
    }
}