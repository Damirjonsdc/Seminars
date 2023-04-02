using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[8];

        Random rnd = new Random();
        for (int i = 0; i < arr.Length; i++)
            arr[i] = rnd.Next(2);

       string myString = string.Join(",", arr);
       Console.WriteLine("Массив:"+ myString);
       /* for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");

        Console.ReadKey();*/
    }
}
