using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a decimal number to convert to binary:");

        int dec = Convert.ToInt32(Console.ReadLine());

        string bin = Convert.ToString(dec, 2);

        Console.WriteLine($"The binary representation of {dec} is: {bin}");
    }
}