using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите пятизначное число:");
        int number = int.Parse(Console.ReadLine());

        bool isPalindrome = IsPalindrome(number);
        if (isPalindrome)
        {
            Console.WriteLine("Это число является палиндромом");
        }
        else
        {
            Console.WriteLine("Это число не является палиндромом");
        }

        Console.ReadKey();
    }

    static bool IsPalindrome(int number)
    {
        string strNumber = number.ToString();
        int length = strNumber.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (strNumber[i] != strNumber[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}