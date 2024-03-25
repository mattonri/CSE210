
public abstract class mrtShape
{
    private string _color;

    public mrtShape()
    {

    }
    public mrtShape(string p_color)
    {
        _color = p_color;
    }
    public void mrtSetColor(string p_color)
    {
        _color = p_color;
    }
    public string mrtGetColor()
    {
        return _color;
    }
    public abstract double mrtGetArea();
}