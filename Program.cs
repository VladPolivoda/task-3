using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть довжини сторін трикутника a, b, c: ");
        string[] input = Console.ReadLine().Split(' ');
        double a = Convert.ToDouble(input[0]);
        double b = Convert.ToDouble(input[1]);
        double c = Convert.ToDouble(input[2]);

        if ((a + b > c) && (a + c > b) && (b + c > a))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Трикутник з сторонами {a}, {b}, {c} існує.");

            if (a == b || b == c || a == c)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Трикутник з сторонами {a}, {b}, {c} є рівнобедреним.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Трикутник з сторонами {a}, {b}, {c} не є рівнобедреним.");
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Трикутник з сторонами {a}, {b}, {c} не існує.");
        }

        Console.ResetColor();
    }
}
