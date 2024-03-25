

public class mrtSquare : mrtShape
{
    double _side;

    public mrtSquare(double p_side, string p_color) : base(p_color)
    {
        _side = p_side;
    }
    public override double mrtGetArea()
    {
        double _area = _side*_side;
        return _area;
    }
}