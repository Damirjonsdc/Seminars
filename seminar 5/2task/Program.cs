using System;

class Program
{
    static void Main()
    {
        int[] myArray = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        int searchNumber = 8;

        bool isFound = false;

        for (int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] == searchNumber)
            {
                isFound = true;
                break;
            }
        }

        if (isFound)
        {
            Console.WriteLine(searchNumber + " is found in myArray.");
        }
        else
        {
            Console.WriteLine(searchNumber + " is not found in myArray.");
        }

        Console.ReadLine();
    }
}