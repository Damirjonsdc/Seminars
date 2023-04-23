/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int N = 10; // значение N

        PrintNumbers(1, N); // вызываем метод для вывода чисел
    }

    static void PrintNumbers(int start, int end)
    {
        if (start <= end) // если начальное число не превышает конечное
        {
            Console.Write(start + " "); // выводим текущее число
            PrintNumbers(start + 1, end); // вызываем рекурсию для следующего числа
        }
    }
}