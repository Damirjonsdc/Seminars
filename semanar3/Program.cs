using System;

class Program {
    static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine()); // Считываем число n
        Console.WriteLine("Таблица квадратов чисел от 1 до " + n);
        Console.WriteLine("-----------------------------------");

        for (int i = 1; i <= n; i++) {
            Console.Write("{0,4}", i * i); // Выводим квадрат числа с отступом в 4 символа
        }
    }
}