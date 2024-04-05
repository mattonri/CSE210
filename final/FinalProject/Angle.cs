

public class Angle
{
    // By default the angle is stored in Radians
    private decimal _angle;
    private Point _point;
    private Segment _segment1;
    private Segment _segment2;

    public Angle(decimal p_angle, Point p_point=null, Segment p_segment1=null, Segment p_segment2=null)
    {
        _angle = p_angle;
        _point = p_point;
        _segment1 = p_segment1;
        _segment2 = p_segment2;
    }
    public static decimal operator -(Angle a, Angle b)
    {
        return a.ReturnRadians() - b.ReturnRadians();
    }
    public static decimal operator +(Angle a, Angle b)
    {
        return a.ReturnRadians() + b.ReturnRadians();
    }
    public decimal ReturnRadians()
    {
        return _angle;
    }
    public decimal ConvertToDegrees()
    {
        return (_angle * 180) / (decimal)Math.PI;
    }
    public Point ReturnPoint()
    {
        return _point;
    }
    public string ReturnString()
    {
        return $"Angle: {_angle} at Point: {_point}\nBetween lines: {_segment1} and {_segment2}";
    }
}