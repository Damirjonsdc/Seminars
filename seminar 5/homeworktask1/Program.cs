using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10]; // Создаем массив из 10 чисел
        Random rand = new Random(); // Создаем объект для генерации случайных чисел
        
        // Заполняем массив случайными положительными трехзначными числами
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(100, 1000);
        }
        
        // Считаем количество четных чисел в массиве
        int count = 0;
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                count++;
            }
        }
        
        // Выводим результат
        Console.WriteLine($"Количество четных чисел в массиве: {count}");
    }
}