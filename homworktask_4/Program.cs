using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число N:");

        int n = int.Parse(Console.ReadLine()); // считываем число N

        Console.Write("Чётные числа от 1 до " + n + ":");

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0) // проверяем, является ли число чётным
            {
                Console.Write(" " + i); // выводим чётное число
            }
        }

        Console.ReadLine(); // ждём, пока пользователь нажмёт Enter
    }
}