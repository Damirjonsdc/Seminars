 /*
 Напишите программу, которая заполнит спирально массив 4 на 4.
 */
int[,] arr = new int[4, 4];

int counter = 1;
int rowStart = 0;
int rowEnd = arr.GetLength(0) - 1;
int colStart = 0;
int colEnd = arr.GetLength(1) - 1;

while (rowStart <= rowEnd && colStart <= colEnd)
{
    // Fill the top row
    for (int i = colStart; i <= colEnd; i++)
    {
        arr[rowStart, i] = counter++;
    }
    rowStart++;

    // Fill the right column
    for (int i = rowStart; i <= rowEnd; i++)
    {
        arr[i, colEnd] = counter++;
    }
    colEnd--;

    // Fill the bottom row
    if (rowStart <= rowEnd)
    {
        for (int i = colEnd; i >= colStart; i--)
        {
            arr[rowEnd, i] = counter++;
        }
        rowEnd--;
    }

    // Fill the left column
    if (colStart <= colEnd)
    {
        for (int i = rowEnd; i >= rowStart; i--)
        {
            arr[i, colStart] = counter++;
        }
        colStart++;
    }
}

// Print the resulting array
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + "\t");
    }
    Console.WriteLine();
}