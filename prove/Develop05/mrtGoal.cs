

using System.Security.Cryptography;

public abstract class mrtGoal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public mrtGoal(string p_name, string p_description, int p_points)
    {
        _name = p_name;
        _description = p_description;
        _points = p_points;
    }

    public abstract string mrtToCSV();
    public abstract string mrtToString();
    public abstract int mrtRecordEvent();
    public abstract bool mrtIsCompleted();
}