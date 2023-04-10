using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int[] copy = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            copy[i] = arr[i];
        }

        Console.WriteLine("Original array:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\nCopied array:");
        foreach (int num in copy)
        {
            Console.Write(num + " ");
        }
    }
}