using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please Guess a number: ");
        int guess = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,100);
        while (guess != randomNumber)
        {
            if (guess > randomNumber) 
            {
            Console.WriteLine($"Sorry! It's Try a number a little lower!");
            }
            else 
            {
            Console.WriteLine($"Sorry! It's Try a number a little higher!");
            }
            Console.Write($"What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("You got it!");
    }
}