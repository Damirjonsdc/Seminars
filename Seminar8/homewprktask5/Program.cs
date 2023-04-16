 /*
 Напишите программу, которая заполнит спирально массив 4 на 4.
 */
 
using System;

class Program {
    static void Main(string[] args) {
        int[,] array = new int[4,4];
        int value = 1;
        int rows = 4, cols = 4;
        int startRow = 0, startCol = 0;
        while (rows > 0 && cols > 0) {
            // заполнение верхней строки
            for (int i = 0; i < cols; i++) {
                array[startRow, startCol + i] = value++;
            }
            startRow++;

            // заполнение правого столбца
            for (int i = 0; i < rows - 1; i++) {
                array[startRow + i, startCol + cols - 1] = value++;
            }
            cols--;

            // заполнение нижней строки
            if (rows > 1) {
                for (int i = cols - 1; i >= 0; i--) {
                    array[startRow + rows - 1, startCol + i] = value++;
                }
                rows--;
            }

            // заполнение левого столбца
            if (cols > 1) {
                for (int i = rows - 1; i >= 1; i--) {
                    array[startRow + i, startCol] = value++;
                }
                startCol++;
            }
        }

        // вывод массива
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
