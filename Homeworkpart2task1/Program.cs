using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите трехзначное число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        
        int secondDigit = (num / 10) % 10; // получаем вторую цифру
        
        Console.WriteLine("Вторая цифра введенного числа: " + secondDigit);
        Console.ReadKey();
    }
}