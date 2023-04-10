using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three side lengths of a triangle: ");

        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("This is a valid triangle.");
        }
        else
        {
            Console.WriteLine("This is not a valid triangle.");
        }
    }
}