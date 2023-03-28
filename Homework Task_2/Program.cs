using System;

namespace CompareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} Больше,чем {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} Меньше,чем {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} и {num2} равны");
            }

            Console.ReadLine();
        }
    }
}



