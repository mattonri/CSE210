// [Serializable]
// public class InvalidDepartmentException : Exception
// {
//     public InvalidDepartmentException() : base() { }
//     public InvalidDepartmentException(string message) : base(message) { }
//     public InvalidDepartmentException(string message, Exception inner) : base(message, inner) { }
// }
[Serializable]
public class ImpossibleShapeException : Exception
{
    public ImpossibleShapeException() : base() { }
    public ImpossibleShapeException(string message) : base(message) { }
    public ImpossibleShapeException(string message, Exception inner) : base(message, inner) { }
}