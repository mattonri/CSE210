

using System.Diagnostics.CodeAnalysis;

public class Segment
{
    private decimal? _length = null;
    private Point _starting_point;
    private Point _ending_point;

    public Segment(Point p_starting, decimal p_length, Point p_ending=null, decimal p_tolerance=0)
    {
        _starting_point = p_starting;
        _length = p_length;
        if (p_ending != null)
        {
            try
            {
                _length = p_length;
                decimal _calculatedLength = p_starting.DistanceFrom(p_ending);
                if(Math.Abs(_calculatedLength - (decimal)_length) <= p_tolerance)
                {
                    throw new ImpossibleShapeException();
                }
                else
                {
                    _ending_point = p_ending;
                }
            }
            catch (ImpossibleShapeException e)
            {
                throw new ImpossibleShapeException("Cannot create line from points with incorrect distance", e);
            }
        }
    }
    public Segment(Point p_starting, Point p_ending)
    {
        _starting_point = p_starting;
        _ending_point = p_ending;
        _length = p_starting.DistanceFrom(p_ending);
    }
    public decimal ReturnLength()
    {
        return (decimal)_length;
    }
    public Point ReturnStartingPoint()
    {
        return _starting_point;
    }
    public Point ReturnEndingPoint()
    {
        return _ending_point;
    }
    public void SetEndPoint(Point p_endPoint)
    {
        try
        {
            if(_ending_point == null)
            {
                _ending_point = p_endPoint;
            }
            else
            {
                throw new CannotOverwriteException();
            }
        }
        catch (CannotOverwriteException e)
        {
            throw new CannotOverwriteException("Overwrite the existing endpoint of a line segment", e);
        }

    }

}