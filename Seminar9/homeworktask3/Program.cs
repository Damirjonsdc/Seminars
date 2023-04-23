using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите число n: ");
        int n = int.Parse(Console.ReadLine());

        int result = AckermannFunction(m, n);
        Console.WriteLine($"Результат функции Аккермана для m={m} и n={n} равен {result}.");
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
            return n + 1;
        if (m > 0 && n == 0)
            return AckermannFunction(m - 1, 1);
        if (m > 0 && n > 0)
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        return -1; // В случае неверных значений аргументов
    }
}