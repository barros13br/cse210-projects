using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do
        {
            Console.Write("Insert the magic number: ");
            string InputNumber = Console.ReadLine();
            int MagicNumber = int.Parse(InputNumber);


            Console.Write("Guess the magic number: ");
            string InputNumber2 = Console.ReadLine();
            int GuessNumber = int.Parse(InputNumber2);

            if (GuessNumber == MagicNumber)
            {
                Console.WriteLine("You guessed it! ");
            }
            else
            {
                while (GuessNumber != MagicNumber)
                {
                    if (GuessNumber > MagicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("Higher");
                    }

                    Console.Write("Guess the magic number: ");
                    InputNumber2 = Console.ReadLine();
                    GuessNumber = int.Parse(InputNumber2);
                }
            }
            if (GuessNumber == MagicNumber)
            {
                Console.WriteLine("You guessed it! ");
            }
            Console.WriteLine("Do you want to play again ? (yes / no) ");
            response = Console.ReadLine();
        } while (response == "yes");

    }

}