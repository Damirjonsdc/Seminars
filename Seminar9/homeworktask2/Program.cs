/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using System;

class Program
{
    static void Main()
    {
        int M = 1; // задаем значение M
        int N = 10; // задаем значение N
        int sum = SumNatural(M, N); // вызываем функцию SumNatural для нахождения суммы
        Console.WriteLine("Сумма натуральных чисел от {0} до {1} равна {2}", M, N, sum);
    }

    static int SumNatural(int M, int N)
    {
        if (M > N) // проверяем условие окончания рекурсии
        {
            return 0;
        }
        else
        {
            return M + SumNatural(M+1, N); // рекурсивный вызов с увеличением аргумента M на единицу
        }
    }
}

