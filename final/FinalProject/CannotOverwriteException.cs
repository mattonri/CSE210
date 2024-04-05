[Serializable]
public class CannotOverwriteException : Exception
{
    public CannotOverwriteException() : base() { }
    public CannotOverwriteException(string message) : base(message) { }
    public CannotOverwriteException(string message, Exception inner) : base(message, inner) { }
}