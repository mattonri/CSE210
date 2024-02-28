using System;
using System.Globalization;
using C = System.Console;

class Program
{
    static void Main(string[] args)
    {
        C.WriteLine("Hello! Please enter numbers in the list!\nEnter '0' when you want to stop");
        float mrtuserInput = 99;
        List<float> mrtnumList = new List<float>();
        while (mrtuserInput != 0)
        {
            C.Write("Enter a number: ");
            mrtuserInput = float.Parse(C.ReadLine());
            if (mrtuserInput != 0)
            {
                mrtnumList.Add(mrtuserInput);
            }
        }
        float mrtsum = 0;
        foreach (float mrtnum in mrtnumList)
        {
            mrtsum += mrtnum;
        }
        C.WriteLine($"Your sum is: {mrtsum}");
        float mrtaverage = mrtsum / mrtnumList.Count();
        C.WriteLine($"Your average is: {mrtsum} / {mrtnumList.Count()} which is {mrtaverage.ToString("n6")}");
        float mrtlargest = 0;
        foreach (float mrtnum in mrtnumList)
        {
            if (mrtnum > mrtlargest)
            {
                mrtlargest = mrtnum;
            }
        }
        float mrtpositiveLargest = 999;
        foreach (float mrtnum in mrtnumList)
        {
            if (mrtnum < mrtpositiveLargest && mrtnum >= 0)
            {
                mrtpositiveLargest = mrtnum;
            }
        }
        C.WriteLine($"The smallest positive number is: {mrtpositiveLargest}");
        C.WriteLine($"The sorted list is:");
        mrtnumList.Sort();
        foreach (float mrtnum in mrtnumList)
        {
            C.WriteLine($"{mrtnum}");
        }
    }
}