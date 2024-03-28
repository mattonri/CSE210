
public class mrtCheckList : mrtGoal
{
    private bool _completed;
    private int _total;
    private int _current;
    private int _bonus;

    public mrtCheckList(string p_name, string p_description, int p_points, int p_bonus, int p_total, int p_current=0, bool p_completed=false) : base(p_name, p_description, p_points)
    {
        _completed = p_completed;
        _bonus = p_bonus;
        _total = p_total;
        _current = p_current;
    }



    public override string mrtToCSV()
    {
        string _constructedString = $"CheckListGoal:{_name},{_description},{_points},{_completed},{_bonus},{_total},{_current}";
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
        string _constructedString = $"[{_check}] {_name} ({_description}) -- Currently Completed: {_current}/{_total}";
        return _constructedString;
    }
    public override int mrtRecordEvent()
    {
        int _pointGain;
        if(_completed)
        {
            _pointGain = 0;
        }
        else if(_total == _current + 1)
        {
            _pointGain = _points + _bonus;
            _completed = true;
            _current++;
        }
        else
        {
            _pointGain = _points;
            _current++;
        }
        return _pointGain;
    }
    public override bool mrtIsCompleted()
    {
        bool _isCompleted = _completed;
        return _isCompleted;
    }
}