using System;

class Program
{
    static void Main(string[] args)
    {
        // Задаем размеры массива
        int m = 5; // Кол-во строк
        int n = 3; // Кол-во столбцов

        // Создаем двумерный массив
        double[,] array = new double[m, n];

        // Заполняем массив случайными значениями
        Random random = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.NextDouble() * 10;
            }
        }

        // Выводим массив на экран
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + "\t"); // "\t" - символ табуляции, для вывода значений в рядок
            }
            Console.WriteLine(); // Переход на новую строку
        }

        Console.ReadKey(); // Ожидаем нажатия любой клавиши
    }
}