using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите три числа:");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int max = a;

        if (b > max) max = b;
        if (c > max) max = c;

        Console.WriteLine("Максимальное число: " + max);

        Console.ReadLine();
    }
}