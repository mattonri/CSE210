

public class mrtCircle : mrtShape
{
    double _radius;

    public mrtCircle(double p_radius, string p_color) : base(p_color)
    {
        _radius = p_radius;
    }
    public override double mrtGetArea()
    {
        double _area = _radius*_radius*Math.PI;
        return _area;
    }
}