int[,] array = new int[3,3] {{1,47,2}, {5,92,3}, {8,42,4}};

for(int i=1; i<array.GetLength(0); i+=2)
{
    for(int j=1; j<array.GetLength(1); j+=2)
    {
        array[i,j] = array[i,j]*array[i,j];
    }
}

//вывод массива в консоль
for(int i=0; i<array.GetLength(0); i++)
{
    for(int j=0; j<array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
}
