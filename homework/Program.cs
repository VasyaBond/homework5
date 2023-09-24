using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        if (!int.TryParse(Console.ReadLine(), out int number))
        {
            Console.WriteLine("Ошибка ввода. Введите трехзначное число.");
            return;
        }

        if (number < 100 || number > 999)
        {
            Console.WriteLine("Ошибка ввода. Введите трехзначное число.");
            return;
        }

        int secondDigit = (number / 10) % 10;

        Console.WriteLine("Вторая цифра числа: " + secondDigit);
    }
}
