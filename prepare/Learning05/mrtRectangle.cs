using System.Diagnostics.Contracts;

public class mrtRectangle : mrtShape
{
    double _length;
    double _width;

    public mrtRectangle(double p_length, double p_width, string p_color) : base(p_color)
    {
        _length = p_length;
        _width = p_width;
    }
    public override double mrtGetArea()
    {
        double _area = _length*_width;
        return _area;
    }
}