

using System.Diagnostics.CodeAnalysis;

public class Segment
{
    private decimal? _length = null;
    private Point _startingPoint;
    private Point _endingPoint;

    public Segment(Point p_starting, decimal p_length, Point p_ending=null, decimal p_tolerance=0)
    {
        _startingPoint = p_starting;
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
                    _endingPoint = p_ending;
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
        _startingPoint = p_starting;
        _endingPoint = p_ending;
        _length = p_starting.DistanceFrom(p_ending);
    }
    public decimal ReturnLength()
    {
        return (decimal)_length;
    }
    public Point ReturnStartingPoint()
    {
        return _startingPoint;
    }
    public Point ReturnEndingPoint()
    {
        return _endingPoint;
    }
    public void SetEndPoint(Point p_endPoint)
    {
        try
        {
            if(_endingPoint == null)
            {
                _endingPoint = p_endPoint;
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
    public Point PartialTransitionAlong(decimal p_ratio)
    {
        try
        {
            decimal? _startingPointX = _startingPoint.GetXY().Item1;
            decimal? _startingPointY = _startingPoint.GetXY().Item2;
            decimal? _endingPointX = _endingPoint.GetXY().Item1;
            decimal? _endingPointY = _endingPoint.GetXY().Item2;

            if(_endingPointX != null || _endingPointY != null || _startingPointX != null || _startingPointY != null)
            {
                decimal _segmentDeltaX = (-(decimal)_startingPointX + (decimal)_endingPointX) * p_ratio;
                decimal _segmentDeltaY = (-(decimal)_startingPointY + (decimal)_endingPointY) * p_ratio;
                
                Point _returnPoint = _startingPoint.Transition(_segmentDeltaX, _segmentDeltaY);
                return _returnPoint;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
        catch (ArgumentNullException e)
        {
            throw new ArgumentNullException("Cannot Perform a partial transition along a segment with null points", e);
        }
    }

}