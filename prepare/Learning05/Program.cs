using System;

class Program
{
    static void Main(string[] args)
    {
        List<mrtShape> mrtShapeList = new List<mrtShape>();
        
        mrtShapeList.Add(new mrtRectangle(2.5,1.5, "blue"));
        mrtShapeList.Add(new mrtCircle(6, "red"));
        mrtShapeList.Add(new mrtSquare(4, "green"));
        foreach(mrtShape _shape in mrtShapeList)
        {
            Console.WriteLine(_shape.mrtGetColor());
            Console.WriteLine(_shape.mrtGetArea());
            
        }
    }
}