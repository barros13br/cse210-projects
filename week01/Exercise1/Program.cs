using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name ?");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your last name ?");
        string LastName = Console.ReadLine();
        Console.Write($"Your name is {LastName}, {firstName} {LastName}.");
    }
}