using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Program
{
    decimal mrtTolerance = .01m;
    public decimal XYDistance(decimal x1, decimal y1, decimal x2, decimal y2)
    // return distance between two xy points on a plane
    {
        return (decimal)Math.Sqrt(Math.Pow((double)x1-(double)x2, 2) + Math.Pow((double)y1-(double)y2, 2));
    }
    public decimal CoSinRule(decimal a,decimal b,decimal c)
    //return angle across from side A
    {
        return (decimal)Math.Acos((Math.Pow((double)b, 2) + Math.Pow((double)c, 2) - Math.Pow((double)a, 2))/(2*(double)b*(double)c));
    }
    public decimal FindAdjacent(decimal p_hypotenuse, decimal p_angle)
    {
        return (decimal)Math.Cos((double)p_angle)*p_hypotenuse;
    }
    public decimal FindOpposite(decimal p_hypotenuse, decimal p_angle)
    {
        return (decimal)Math.Sin((double)p_angle)*p_hypotenuse;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
    // x1 y1, d1.   x2, y2, d2
    // p1-to-p2 
    // p1, deg/p2, deg -> right angle triangle to get deltaX and deltaY for distance
    // Find answer points: xA, yA, xB, yB, 1 for positive & for negative answers
    // x3, y3, d3 - Draw right angle rectangle to points A and B and check distances
    // 
    // decimal x1 = -10;
    // decimal y1 = 5;
    // decimal d1 = 20;

    // decimal x2 = 20;
    // decimal y2 = 15;
    // decimal d2 = 40;


    // // Answer should be (-1, 2) OR (0-1, -5--6)
    // decimal x1 = -2;
    // decimal y1 = -2;
    // decimal d1 = 4.1231056256;

    // decimal x2 = 2;
    // decimal y2 = -1;
    // decimal d2 = 4.2426406871;

    // decimal x3;
    // decimal y3;
    // decimal d3;
    
    // Answer should be (1, 3) OR (1, 1)
    decimal x1 = 0m;
    decimal y1 = 2m;
    decimal d1 = 1.41m;
    Point mrtPoint1 = new Point(0, 2);
    Segment mrtSegment1_T = new Segment(p_starting: mrtPoint1,p_length:1.41m);
    decimal x2 = 2m;
    decimal y2 = 2m;
    decimal d2 = 1.41m;
    Point mrtPoint2 = new Point(2, 2);
    Segment mrtSegment2_T = new Segment(p_starting: mrtPoint2,p_length:1.41m);
    // Segment test = new Segment(mrtPoint1, mrtPoint2);
    // Console.WriteLine(test.ReturnEndingPoint());

    decimal x3;
    decimal y3;
    decimal d3;
    

    Program Program = new Program();
    // 1
    Segment mrtSegment1_2 = new Segment(p_starting: mrtPoint1, p_ending: mrtPoint2);
    Console.WriteLine($"{mrtSegment1_2.ReturnLength()}");
    // 2
    decimal p1Angle = Program.CoSinRule(d2, d1, d1_2);
    Console.WriteLine($"{p1Angle}");
    // 3
    decimal d1_3 = Program.FindAdjacent(d1, p1Angle);
    Console.WriteLine($"{d1_3}");
    decimal d3_ratio = d1_3/d1_2;
    Console.WriteLine($"{d3_ratio}");

    decimal delta1_2X = x2 - x1;
    Console.WriteLine($"{delta1_2X}");
    decimal delta1_2Y = y2 - y1;
    Console.WriteLine($"{delta1_2Y}");

    decimal delta1_3X = delta1_2X * d3_ratio;
    Console.WriteLine($"{delta1_3X}");
    decimal delta1_3Y = delta1_2Y * d3_ratio;
    Console.WriteLine($"{delta1_3Y}");

    // 4
    decimal p1AbsoluteAngle = Program.CoSinRule(a:delta1_3Y, b:delta1_3X, c:d1_3) + p1Angle;
    // 5
    decimal delta1_Tx = Program.FindAdjacent(p_angle: p1AbsoluteAngle, p_hypotenuse: d1);
    decimal delta1_Ty = Program.FindOpposite(p_angle: p1AbsoluteAngle, p_hypotenuse: d1);
    // 6
    decimal xT = x1 + delta1_Tx;
    decimal yT = y1 + delta1_Ty;
    Console.WriteLine($"The point is at: ({xT},{yT})");  

    // 4.5
     p1AbsoluteAngle = -Program.CoSinRule(a:delta1_3Y, b:delta1_3X, c:d1_3) + p1Angle;
    // 5.5
     delta1_Tx = Program.FindAdjacent(p_angle: p1AbsoluteAngle, p_hypotenuse: d1);
     delta1_Ty = Program.FindOpposite(p_angle: p1AbsoluteAngle, p_hypotenuse: d1);
    // 6.5
     xT = x1 + delta1_Tx;
     yT = y1 - delta1_Ty;
    Console.WriteLine($"Or the point is at: ({xT},{yT})");

    
    }


}