using System;

class Program 
{
    static void Main(string[] args)
    {
        DisplayName();
        string mrtuserName = PromptUserName();
        float mrtuserNumber = PromptUserNumber();
        float mrtuserNumberSqd = SquareNumber(mrtuserNumber);
        DisplayResult(mrtuserName, mrtuserNumberSqd);
    }
    static void DisplayName()
    {
        Console.WriteLine("Welcome to the Pragram!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }
    static float PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        float userNumber = float.Parse(Console.ReadLine());
        return userNumber;
    }
    static float SquareNumber(float inputNum)
    {
        float squaredNumber = (inputNum * inputNum);
        return squaredNumber;
    }
    static void DisplayResult(string userName, float sqdNum)
    {
        Console.WriteLine($"Hello {userName}!");
        Console.WriteLine($"Your favorite number squared is {sqdNum}");

    }
}