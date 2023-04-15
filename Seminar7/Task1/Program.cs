/*Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4. 0 1 23
1 2 34
2 3 45 */
Console.WriteLine("Введите значение m");
bool isParsem = int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("Введите значение n");
bool isParsen = int.TryParse(Console.ReadLine(), out int n);
if (!isParsem || !isParsen)
{
    return;
}

int[,] array = Generate2DArray(m,n);
Print2DArray(array);

int[,] Generate2DArray(int m, int n)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = i+j;
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}