using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        
        int digit = 0;
        if (number >= 100 && number <= 999)
            digit = (number / 10) % 10;
        else
            Console.WriteLine("Третьей цифры нет.");
        
        Console.WriteLine("Третья цифра числа {0}: {1}", number, digit);
    }
}