﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of Fibonacci numbers to display:");
        int n = Convert.ToInt32(Console.ReadLine());

        int a = 0;
        int b = 1;
        int c;

        Console.Write(a + " " + b + " ");

        for (int i = 2; i < n; i++)
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }
}