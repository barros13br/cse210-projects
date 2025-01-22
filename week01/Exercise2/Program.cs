using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade porcentage: ");
        string value = Console.ReadLine();
        int grade = int.Parse(value);

        int signal = grade;
        string simbol = "";
        if (signal >= 87 && signal < 90 || signal >= 77 && signal < 80 || signal >= 67 && signal < 70)
        {
            simbol = "+";
        }
        else if (signal < 93 && signal > 90||signal < 83 && signal > 80|| signal < 73 && signal > 70|| signal < 63 && signal > 60)
        {
            simbol = "-";
        }
        else
        {
            simbol = "";
        }
// This is the A grade code
        if (grade >= 90)
        {
            Console.WriteLine($"Your grade is A{simbol}");
        }
        else if (grade >=80)
        {
            Console.WriteLine($"Your grade is B{simbol}");
        }
        else if (grade >=70)
        {
            Console.WriteLine($"Your grade is C{simbol}");
        }
        else if (grade >=60)
        {
            Console.WriteLine($"Your grade is D{simbol}");
        }
        else
        {
            Console.WriteLine("Your grade is F");
        }

        if (grade >= 70)
        {
            Console.Write("CONGRATULATIONS !!! YOU PASS THIS CLASS. ");
        }
        else
        {
            Console.Write("Unfortunately You do not pass the class... I encourage you trying! ");
        }
        
    }
}