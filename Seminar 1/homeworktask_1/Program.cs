using System;

namespace CompareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} is less than {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are equal");
            }

            Console.ReadLine();
        }
    }
}