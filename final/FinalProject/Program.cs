using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        // You can change this value to ask the user to set a tolerance to 
        bool mrtAskTolerance = false;
        Console.WriteLine("Welcome to The Point Calculator!");
        GeometryCalculator mrtMainCalculations = new GeometryCalculator();
        string mrtentry = "";
        string mrtFileName = "";
        decimal mrtPoint1x = 0m;
        decimal mrtPoint1y = 0m;
        decimal mrtPoint2x = 0m;
        decimal mrtPoint2y = 0m;
        decimal mrtDistance1 = 0m;
        decimal mrtDistance2 = 0m;
        decimal mrtTolerance = 0m;
        while(mrtentry != "4")
        {
            Console.WriteLine("Please select one of the following options:");
            Console.Write("1. Perform a new calculation \n2. Save a current calculation \n3. Load a calculation \n4. Quit \n");
            mrtentry = Console.ReadLine();
            Console.Clear();
            if(mrtentry == "1")
            {
                Console.WriteLine("Be sure that the points and distances you enter can reach each other");
                Console.WriteLine("Please enter the X Coordinate of Point 1");
                 mrtPoint1x = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the Y Coordinate of Point 1");
                 mrtPoint1y = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the X Coordinate of Point 2");
                 mrtPoint2x = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the Y Coordinate of Point 2");
                 mrtPoint2y = decimal.Parse(Console.ReadLine());
                
                Point mrtPoint1 = new Point(mrtPoint1x, mrtPoint1y);
                Point mrtPoint2 = new Point(mrtPoint2x, mrtPoint2y);
                Console.WriteLine("Please enter the distance of your target from Point 1");
                 mrtDistance1 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the distance of your target from Point 2");
                 mrtDistance2 = decimal.Parse(Console.ReadLine());
                if(mrtAskTolerance)
                {
                    Console.WriteLine("Please enter tolerance that you want to give to certain matching calculations");
                    mrtTolerance = decimal.Parse(Console.ReadLine());
                }
                else
                {
                    mrtTolerance = .01m;
                }

                (Point, Point) mrtPossiblePoints = mrtMainCalculations.CalculateThirdPoints(mrtTolerance, mrtPoint1, mrtPoint2, mrtDistance1, mrtDistance2);
                Console.WriteLine($"The point is at: {mrtPossiblePoints.Item1.ReturnString()}");  
                Console.WriteLine($"OR the point is at: {mrtPossiblePoints.Item2.ReturnString()}");
            }
            else if(mrtentry == "2")
            {
                Console.WriteLine("What do you want to save the file as?");
                mrtFileName = Console.ReadLine();
                mrtSaveFile(mrtFileName, mrtPoint1x, mrtPoint1y, mrtPoint2x, mrtPoint2y, mrtDistance1, mrtDistance2, mrtTolerance);
            }
            else if(mrtentry == "3")
            {
                Console.WriteLine("What file would you like to load?");
                mrtFileName = Console.ReadLine();
                (mrtPoint1x, mrtPoint1y, mrtPoint2x, mrtPoint2y, mrtDistance1, mrtDistance2, mrtTolerance) = mrtLoadFile(mrtFileName);
                Point mrtPoint1 = new Point(mrtPoint1x, mrtPoint1y);
                Point mrtPoint2 = new Point(mrtPoint2x, mrtPoint2y);
                (Point, Point) mrtPossiblePoints = mrtMainCalculations.CalculateThirdPoints(mrtTolerance, mrtPoint1, mrtPoint2, mrtDistance1, mrtDistance2);
                Console.WriteLine($"The point is at: {mrtPossiblePoints.Item1.ReturnString()}");  
                Console.WriteLine($"OR the point is at: {mrtPossiblePoints.Item2.ReturnString()}");
            }
            else if(mrtentry != "4")
            {
            Console.WriteLine("Sorry, that isn't a valid entry. Please try again!");
            }
        }
        
        // Point mrtPoint1 = new Point(0, 2);
        // Point mrtPoint2 = new Point(2, 2);
        // decimal mrtDistance1 = 1.41m;
        // decimal mrtDistance2 = 1.41m;
        // decimal mrtTolerance = .01m;
    }
    static void mrtSaveFile(string _filePath, decimal mrtPoint1x, decimal mrtPoint1y, decimal mrtPoint2x, decimal mrtPoint2y, decimal mrtDistance1, decimal mrtDistance2, decimal mrtTolerance)
    {
        using (StreamWriter _writerObj = new StreamWriter(_filePath, false))
        {
            _writerObj.WriteLine(mrtPoint1x);
            _writerObj.WriteLine(mrtPoint1y);
            _writerObj.WriteLine(mrtPoint2x);
            _writerObj.WriteLine(mrtPoint2y);
            _writerObj.WriteLine(mrtDistance1);
            _writerObj.WriteLine(mrtDistance2);
            _writerObj.WriteLine(mrtTolerance);
        }
        Console.WriteLine($"Calculation saved to: {_filePath}");
    }
    static (decimal, decimal, decimal, decimal, decimal, decimal, decimal) mrtLoadFile(string p_fileName)
    {
        decimal _point1x;
        decimal _point1y;
        decimal _point2x;
        decimal _point2y;
        decimal _distance1;
        decimal _distance2;
        decimal _tolerance;
        if (File.Exists(p_fileName))
        {
            using (StreamReader _readerObj = new StreamReader(p_fileName))
            {
                _point1x= decimal.Parse(_readerObj.ReadLine());
                _point1y= decimal.Parse(_readerObj.ReadLine());
                _point2x= decimal.Parse(_readerObj.ReadLine());
                _point2y= decimal.Parse(_readerObj.ReadLine());
                _distance1= decimal.Parse(_readerObj.ReadLine());
                _distance2= decimal.Parse(_readerObj.ReadLine());
                _tolerance= decimal.Parse(_readerObj.ReadLine());
                return (_point1x, _point1y, _point2x, _point2y, _distance1, _distance2, _tolerance);
            }
        }
        else
        {
            Console.WriteLine($"File not found: {p_fileName}, loading failed");
            return (0m,0m,0m,0m,0m,0m,0m);
        }
    }

}