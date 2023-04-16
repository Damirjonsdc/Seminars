/*
.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

using System;

class Program {
    static void Main(string[] args) {
        int[,,] array = new int[10, 10, 1];
        int number = 10;
        
        // Заполнение массива
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                for (int k = 0; k < 1; k++) {
                    array[i, j, k] = number++;
                }
            }
        }
        
        // Вывод массива
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                Console.Write("[{0},{1},{2}]:", i, j, 0);
                
                for (int k = 0; k < 10; k++) {
                    Console.Write(" {0}", array[i, j, 0]++);
                }
                
                Console.WriteLine();
            }
        }
    }
}