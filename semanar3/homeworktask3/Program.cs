using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Введите число N:");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine("Таблица кубов:");
    for (int i = 1; i <= n; i++) {
      Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
    }
  }
}