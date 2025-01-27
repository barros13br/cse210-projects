using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the progam!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static float PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string input = Console.ReadLine();
            float userNumber = float.Parse(input);
            return userNumber;
        }

        static float SquareNumber(float number_s)
        {
            float Square = number_s * number_s;
            return Square;
        }

        static void DisplayResult(string name, float square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
        }


        DisplayWelcome();

        string name = PromptUserName();
        float number = PromptUserNumber();
        float square = SquareNumber(number);

        DisplayResult(name,square);
        
    }
}