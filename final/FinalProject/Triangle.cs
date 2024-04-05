

public class Triangle
{
    private Angle _angleA;
    private Angle _angleB;
    private Angle _angleC;
    private decimal? _segmentA;
    private decimal? _segmentB;
    private decimal? _segmentC;
    public Triangle(Angle p_angleA=null, Angle p_angleB=null, Angle p_angleC=null, decimal? p_segmentA=null, decimal? p_segmentB=null, decimal? p_segmentC=null, decimal? p_tolerance=null)
    {
        if (p_angleA != null && p_angleB != null && p_angleC != null)
        {
            try
            {
                if(p_angleA + p_angleB + p_angleC.ReturnRadians() - p_tolerance > (decimal?)Math.PI*2)
                {
                    throw new ImpossibleShapeException();
                }
                else
                {
                    _angleA = p_angleA;
                    _angleB = p_angleB;
                    _angleC = p_angleC;
                }
            }
            catch (ImpossibleShapeException e)
            {
                throw new ImpossibleShapeException("Triangle Corners cannot add up to more than 2*pi", e);
            }
        }
        if (p_segmentA != null && p_segmentB != null && p_segmentC != null)
        {
            try
            {
                if(p_segmentA + p_segmentB < p_segmentC - p_tolerance || p_segmentC + p_segmentB < p_segmentA - p_tolerance || p_segmentA + p_segmentC < p_segmentB - p_tolerance)
                {
                    throw new ImpossibleShapeException();
                }
                else
                {
                    _segmentA = p_segmentA;
                    _segmentB = p_segmentB;
                    _segmentC = p_segmentC;
                }
            }
            catch (ImpossibleShapeException e)
            {
                throw new ImpossibleShapeException("Triangle edges must be able to reach each other", e);
            }
        }
        _angleA = p_angleA;
        _angleB = p_angleB;
        _angleC = p_angleC;
        _segmentA = p_segmentA;
        _segmentB = p_segmentB;
        _segmentC = p_segmentC;

    }

    public decimal CoSinRule(decimal p_sideA,decimal p_sideB,decimal p_sideC)
    //return angle across from side A
    {
        return (decimal)Math.Acos((Math.Pow((double)p_sideB, 2) + Math.Pow((double)p_sideC, 2) - Math.Pow((double)p_sideA, 2))/(2*(double)p_sideB*(double)p_sideC));
    }
    public decimal FindAdjacent(decimal p_hypotenuse, decimal p_angle)
    {
        return (decimal)Math.Cos((double)p_angle)*p_hypotenuse;
    }
    public decimal FindOpposite(decimal p_hypotenuse, decimal p_angle)
    {
        return (decimal)Math.Sin((double)p_angle)*p_hypotenuse;
    }
    public string ReturnString()
    {
        return $"Triangle with angles {_angleA.ReturnString()}, {_angleB.ReturnString()}, and {_angleC.ReturnString()}, \nand sides with lengths of: {_segmentA}, {_segmentB}, and {_segmentC} ";
    }
    public void SetAngleA(Angle p_angleA)
    {
        _angleA = p_angleA;
    }
    public void SetAngleB(Angle p_angleB)
    {
        _angleB = p_angleB;
    }
    public void SetAngleC(Angle p_angleC)
    {
        _angleC = p_angleC;
    }
    public void SetSegmentA(decimal p_segmentA)
    {
        _segmentA = p_segmentA;
    }
    public void SetSegmentB(decimal p_segmentB)
    {
        _segmentB = p_segmentB;
    }
    public void SetSegmentC(decimal p_segmentC)
    {
        _segmentC = p_segmentC;
    }
    public Angle ReturnAngleA()
    {
        return _angleA;
    }
    public Angle ReturnAngleB()
    {
        return _angleB;
    }
    public Angle ReturnAngleC()
    {
        return _angleC;
    }
    public decimal? ReturnSegmentA()
    {
        return _segmentA;
    }
    public decimal? ReturnSegmentB()
    {
        return _segmentB;
    }
    public decimal? ReturnSegmentC()
    {
        return _segmentC;
    }
}