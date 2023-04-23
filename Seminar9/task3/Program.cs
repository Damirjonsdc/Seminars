/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12 45 -> 9
*/

using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int sum = SumOfDigits(number);
        Console.WriteLine("Сумма цифр числа {0} равна {1}", number, sum);
    }

    public static int SumOfDigits(int n)
    {
        if (n == 0) // базовый случай
        {
            return 0;
        }
        else // рекурсивный случай
        {
            return n % 10 + SumOfDigits(n / 10);
        }
    }
}
