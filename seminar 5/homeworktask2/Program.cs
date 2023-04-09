using System;

class Program {
  static void Main() {
    Random random = new Random();
    int[] arr = new int[10];

    // заполнение массива случайными числами
    for (int i = 0; i < arr.Length; i++) {
      arr[i] = random.Next(10);
    }

    // вычисление суммы элементов на нечётных позициях
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2) {
      sum += arr[i];
    }

    Console.WriteLine("Массив:");
    Console.WriteLine(string.Join(", ", arr));
    Console.WriteLine("Сумма элементов на нечётных позициях: {0}", sum);
  }
}