using System;

namespace DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод координат двух точек
            Console.WriteLine("Введите координаты первой точки: ");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double z1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты второй точки: ");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double z2 = double.Parse(Console.ReadLine());

            // Вычисление расстояния между точками
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

            // Вывод результата
            Console.WriteLine($"Расстояние между точками: {distance}");
        }
    }
}