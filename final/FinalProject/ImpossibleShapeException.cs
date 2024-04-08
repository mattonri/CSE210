
[Serializable]
public class ImpossibleShapeException : Exception
{
    public ImpossibleShapeException() : base() { }
    public ImpossibleShapeException(string message) : base(message) { }
    public ImpossibleShapeException(string message, Exception inner) : base(message, inner) { }
}