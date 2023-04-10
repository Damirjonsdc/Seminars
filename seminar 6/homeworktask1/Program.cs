using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of integers to input:");
      bool status = int.TryParse(Console.ReadLine(), out int size);

        int[] nums = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter integer {i + 1}:");
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        int count = CountPositive(nums);

        Console.WriteLine($"You entered {count} positive numbers.");
    }

    static int CountPositive(int[] nums)
    {
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                count++;
            }
        }

        return count;
    }
}