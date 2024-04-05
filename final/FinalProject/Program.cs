using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to The Point Calculator! Just input 2 points with 2 distances attached and it will find the possible points of intersection!");
        Point mrtPoint1 = new Point(0, 2);
        Point mrtPoint2 = new Point(2, 2);
        decimal mrtDistance1 = 1.41m;
        decimal mrtDistance2 = 1.41m;
        decimal mrtTolerance = .01m;

        GeometryCalculator mrtMainCalculations = new GeometryCalculator();
        (Point, Point) mrtPossiblePoints = mrtMainCalculations.CalculateThirdPoints(mrtTolerance, mrtPoint1, mrtPoint2, mrtDistance1, mrtDistance2);
        Console.WriteLine($"The point is at: {mrtPossiblePoints.Item1.ReturnString()}");  
        Console.WriteLine($"OR the point is at: {mrtPossiblePoints.Item2.ReturnString()}");

    }


}