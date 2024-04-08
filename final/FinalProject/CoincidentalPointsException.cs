[Serializable]
public class CoincidentalPointsException : Exception
{
    public CoincidentalPointsException() : base() { }
    public CoincidentalPointsException(string message) : base(message) { }
    public CoincidentalPointsException(string message, Exception inner) : base(message, inner) { }
}