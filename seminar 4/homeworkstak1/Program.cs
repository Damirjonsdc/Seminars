using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите степень B: ");
        int b = int.Parse(Console.ReadLine());

        int result = 1;

        for (int i = 1; i <= b; i++)
        {
            result *= a;
        }

        Console.WriteLine("{0} в степени {1} равно: {2}", a, b, result);

        Console.ReadKey();
    }
}