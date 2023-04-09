using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, -2, 3, -4, 5 }; // исходный массив

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0) // если элемент положительный
                array[i] = -array[i]; // меняем знак на отрицательный
            else if (array[i] < 0) // если элемент отрицательный
                array[i] = -array[i]; // меняем знак на положительный
        }

        // выводим измененный массив
        Console.WriteLine("Массив после замены:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
    }
}