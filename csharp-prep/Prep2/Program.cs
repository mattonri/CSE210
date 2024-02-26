using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input your grade as a percentage:");
        string mrtuserInput = Console.ReadLine();
        float grade = float.Parse(mrtuserInput);
        string letterGrade = "unassigned";
        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else if (grade < 60)
        {
            letterGrade = "F";
        }
        else if (grade < 0 || grade > 120)
        {
            letterGrade = "Invalid Input";
        }
        Console.WriteLine($"Your letter grade is {letterGrade}");
        if (grade >= 70)
        {
            Console.WriteLine($"Congrats! You passed!");
        }
        else
        {
            Console.WriteLine($"Sorry, You didn't quite pass.");
        }
    }
}