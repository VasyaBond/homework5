using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1-7) representing the day of the week: ");
        if (!int.TryParse(Console.ReadLine(), out int dayOfWeek) || dayOfWeek < 1 || dayOfWeek > 7)
        {
            Console.WriteLine("Input error. Please enter a valid number between 1 and 7.");
            return;
        }

        if (dayOfWeek == 6 || dayOfWeek == 7)
        {
            Console.WriteLine("Yes, it's a weekend.");
        }
        else
        {
            Console.WriteLine("No, it's not a weekend.");
        }
    }
}
