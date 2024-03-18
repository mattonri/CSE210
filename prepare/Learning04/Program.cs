using System;

class Program
{
    static void Main(string[] args)
    {
        mrtMathAssignment fridayAssignment = new mrtMathAssignment("6.7","What is the square root of the following numbers?:\n16:\n64:\n4:","Daisy","Square Roots");
        Console.WriteLine(fridayAssignment.mrtGetHomeworkList());
    }

}