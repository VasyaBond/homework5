using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Input error. Please enter an integer.");
            return;
        }

        int absNumber = Math.Abs(number);

        if (absNumber < 100)
        {
            Console.WriteLine("No third digit.");
        }
        else
        {
            int thirdDigit = (absNumber / 100) % 10;
            Console.WriteLine("The third digit of the number is: " + thirdDigit);
        }
    }
}
