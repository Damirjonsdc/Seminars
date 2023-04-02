using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        string str = Console.ReadLine();

        int sum = 0;
        foreach (char ch in str)
            sum += ch - '0';

        Console.WriteLine($"Сумма цифр в числе {str} равна {sum}");
    }
}