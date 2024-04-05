

using System.Diagnostics.Contracts;

public class Point
{
    private (decimal?, decimal?) _xyCoords = (null, null);
    private decimal? _xCoord = null;
    private decimal? _yCoord = null;

    public Point()
    {

    }
    public Point(decimal p_xCoord, decimal p_yCoord)
    {
        _xyCoords = (p_xCoord, p_yCoord);
        _xCoord = p_xCoord;
        _yCoord = p_yCoord;
    }

    public Point Transition(decimal? p_deltaX, decimal? p_deltaY)
    {
        try
        {
            if(_xCoord == null || _yCoord == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                Point _returnPoint = new Point((decimal)_xCoord + (decimal)p_deltaX, (decimal)_yCoord + (decimal)p_deltaY);
                return _returnPoint;
            }
        }
        catch (ArgumentNullException e)
        {
            throw new ArgumentNullException("Cannot transition null point.", e);
        }
    }
    public (decimal?, decimal?) GetXY()
    {
        return _xyCoords;
    }
    public bool CheckXY((decimal?, decimal?) p_targetXY, decimal p_tolerance)
    {
        return (Math.Abs(p_targetXY.Item1.Value - _xCoord.Value) <= p_tolerance) && (Math.Abs(p_targetXY.Item2.Value - _yCoord.Value) <= p_tolerance);
    }
    public decimal DistanceFrom(Point p_endPoint)
    {
        try
        {
            if(_xCoord == null || _yCoord == null || p_endPoint.GetXY().Item1 == null || p_endPoint.GetXY().Item2 == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                decimal _distance = (decimal)Math.Sqrt(Math.Pow((double)(_xCoord - p_endPoint.GetXY().Item1), 2) + Math.Pow((double)(_yCoord - p_endPoint.GetXY().Item2), 2));
                return _distance;
            }
        }
        catch (ArgumentNullException e)
        {
            throw new ArgumentNullException("Cannot calculate distance to/from null point", e);
        }
    }
    public string ReturnString()
    {
        return $"({_xCoord}, {_yCoord})";
    }
}