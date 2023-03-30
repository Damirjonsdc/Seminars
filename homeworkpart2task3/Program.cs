using System;

namespace CheckWeekendDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цифру дня недели (от 1 до 7): ");
            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber == 6 || dayNumber == 7)
            {
                Console.WriteLine("Это выходной день!");
            }
            else
            {
                Console.WriteLine("Это рабочий день.");
            }

            Console.ReadKey();
        }
    }
}