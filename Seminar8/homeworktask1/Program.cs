Console.WriteLine("Введите размер двумерного массива");

Console.WriteLine("Введите количество строк");
bool isParsevasizerow = int.TryParse(Console.ReadLine(), out int sizeRow);

Console.WriteLine("Введите количество столбцов");
bool isParsesizecolumn = int.TryParse(Console.ReadLine(), out int sizeColumn);

if (!isParsevasizerow || !isParsesizecolumn) { Console.WriteLine("Ошибка ввода размености, введено не число"); return; }

int[,] array = Generate2DArray(sizeRow, sizeColumn);
Print2DArray(array);
Console.WriteLine();

SortingArrayToRows(array);
Print2DArray(array);
Console.WriteLine();

// Метод создание двумерного массива типа int и заполнения его случайными числами 
int[,] Generate2DArray(int sizeRow, int sizeColumn)
{
    int[,] array = new int[sizeRow, sizeColumn];

    Random random = new Random();

    for (int i = 0; i < sizeRow; i++)
    {
        for (int j = 0; j < sizeColumn; j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}


// Метод вывода двумерного массива в консоль
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}


// Метод сортировки значений строк по убыванию
void SortingArrayToRows (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int max = array[i,j];
            int indexMax = j;

            for (int k = j; k < array.GetLength(1); k++)
            {
                if (max < array[i,k]) { max = array[i,k]; indexMax = k;}
            }

            if (indexMax != j)
            {
                int tmp = array[i, j];
                array[i, j] = array[i, indexMax];
                array[i, indexMax] = tmp;
            }

        }
    }

}