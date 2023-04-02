using System;

namespace MultiplyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N: ");
            int n = int.Parse(Console.ReadLine());
            int product = 1;
            for (int i = 1; i <= n; i++)
            {
                product *= i;
            }

            Console.WriteLine("Произведение чисел от 1 до N равно: " + product);
            Console.ReadKey();
        }
    }
}