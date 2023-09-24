using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        if (!int.TryParse(Console.ReadLine(), out int num1))
        {
            Console.WriteLine("Ошибка ввода для первого числа. Введите целое число.");
            return;
        }

        Console.Write("Введите второе число: ");
        if (!int.TryParse(Console.ReadLine(), out int num2))
        {
            Console.WriteLine("Ошибка ввода для второго числа. Введите целое число.");
            return;
        }

        bool isSquare = false;

        if (num1 > 0 && num2 > 0)
        {
            int sqrtNum1 = (int)Math.Sqrt(num1);
            int sqrtNum2 = (int)Math.Sqrt(num2);

            if (sqrtNum1 == num2 || sqrtNum2 == num1)
            {
                isSquare = true;
            }
        }

        if (isSquare)
        {
            Console.WriteLine("Одно число является квадратом другого.");
        }
        else
        {
            Console.WriteLine("Ни одно из чисел не является квадратом другого.");
        }
    }
}
