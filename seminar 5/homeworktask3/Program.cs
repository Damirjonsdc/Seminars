double[] arr = { 3.14, 2.71, 1.618, 0.577, 1.414 };

double max = arr[0];
double min = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    if (arr[i] < min)
    {
        min = arr[i];
    }
}

double diff = max - min;

Console.WriteLine("Максимальный элемент: " + max);
Console.WriteLine("Минимальный элемент: " + min);
Console.WriteLine("Разница: " + diff);