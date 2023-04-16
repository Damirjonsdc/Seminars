using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        Console.WriteLine("Original array:");
        PrintArray(arr);

        SwapRows(arr, 0, arr.GetLength(0) - 1);

        Console.WriteLine("Updated array:");
        PrintArray(arr);
    }

    static void SwapRows(int[,] arr, int row1, int row2)
    {
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            int temp = arr[row1, i];
            arr[row1, i] = arr[row2, i];
            arr[row2, i] = temp;
        }
    }

    static void PrintArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}