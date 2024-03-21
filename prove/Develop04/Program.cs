using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program");
        string mrtentry = "";
        mrtBreathing mrtbreathing = new mrtBreathing();
        mrtReflection mrtreflection = new mrtReflection();
        mrtListing mrtlisting = new mrtListing();
        while(mrtentry != "4")
        {
            Console.WriteLine("Please select one of the following options:");
            Console.Write("1. Breathing \n2. Reflection \n3. Listing \n4. Quit\n");
            mrtentry = Console.ReadLine();
            Console.Clear();
            if(mrtentry == "1")
            {
                mrtbreathing.mrtRun();
            }
            else if(mrtentry == "2")
            {
                mrtreflection.mrtRun();
            }
            else if(mrtentry == "3")
            {
                mrtlisting.mrtRun();
            }
            else if(mrtentry != "4")
            {
            Console.WriteLine("Sorry, that isn't a valid entry. Please try again!");
            }
        }
    }
}