/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите степень B: ");
        int b = int.Parse(Console.ReadLine());

        int result = Pow(a, b);

        Console.WriteLine($"{a} в степени {b} равно {result}.");
    }

    static int Pow(int a, int b)
    {
        if (b == 0)
        {
            return 1;
        }
        else
        {
            return a * Pow(a, b - 1);
        }
    }
}