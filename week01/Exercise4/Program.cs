using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();


        int number_i = -1;
        while (number_i != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            string input = Console.ReadLine();
            number_i = int.Parse(input);

            if (number_i != 0)
            {
                numbers.Add(number_i);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        float average = 0;
        foreach (float number in numbers)
        {
            average = ((float)sum) / numbers.Count ;
        }

        int larger_number = 0;
        foreach (int number in numbers)
        {
            if (number > larger_number)
            {
                larger_number = number;
            }
        }

        int small_positive = larger_number;
        foreach (int number in numbers)
        {
            if(number < small_positive && number > 0)
            {
                small_positive = number;
            }
        }

        int smalest_number = small_positive;
        foreach (int number in numbers)
        {
            if(number < smalest_number)
            {
                smalest_number = number;
            }
        }
        numbers.Sort();
        Console.WriteLine($"The sum of the List is {sum}");
        Console.WriteLine($"The Average is: {average}");
        Console.WriteLine($"The largest number is: {larger_number}");
        Console.WriteLine($"The smalest positive number is: {small_positive}");
        Console.WriteLine($"The smalest number is: {smalest_number}");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}