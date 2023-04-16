int[,] array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

int rows = array.GetLength(0);
int cols = array.GetLength(1);

if (rows != cols) // проверяем, что матрица является квадратной
{
    Console.WriteLine("Матрица должна быть квадратной");
    return;
}

int[,] result = new int[cols, rows];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        result[j, i] = array[i, j];
    }
}

// вывод результата
for (int i = 0; i < cols; i++)
{
    for (int j = 0; j < rows; j++)
    {
        Console.Write(result[i, j] + " ");
    }

    Console.WriteLine();
}
