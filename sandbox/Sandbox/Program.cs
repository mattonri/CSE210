using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 5;
        int y = 6;
        if (x > y) 
        {
            Console.WriteLine($"{x} is greater than y!");
        }
        else if (x == y || y == x)
        {
            Console.WriteLine($"Sorry, {x} is equal to {y}");
        }
        // You could combine statements. (this one below is redundant)
        else if (x < y && !( x > y) && !(x == y))
        {
            Console.WriteLine($"Sorry, {x} is larger than {y}");
        }
    }
}