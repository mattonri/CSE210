

public class mrtFraction
{
    private int _top;
    private int _bottom;
    public mrtFraction()
    {
        
    }
    public mrtFraction(int _wholeNumber)
    {
        _top = _wholeNumber;
        _bottom = 1;
    }
    public mrtFraction(int _constructorTop, int _constructorBottom)
    {
        _top = _constructorTop;
        _bottom = _constructorBottom;
    }
    public int mrtGetTop()
    {
        return _top;
    }
    public int mrtGetBottom()
    {
        return _bottom;
    }
    public void mrtSetTop(int _paraTop)
    {
        _top = _paraTop;
    }
    public void mrtSetBottom(int _paraBottom)
    {
        _bottom = _paraBottom;
    }
    public string mrtGetFractionString()
    {
        string _fractionString = $"{_top}/{_bottom}";
        return _fractionString;
    }
    public double mrtGetDecimalValue()
    {
        double decimalValue = (float)_top/(float)_bottom;
        return decimalValue;
    }
}