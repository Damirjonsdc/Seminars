/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

Console.WriteLine("Введите размерность массива:");
int lenght = int.Parse(Console.ReadLine());

int[] array = GenerateArray(lenght);

PrintArray(array);

if (lenght % 2 == 0)
{
    int[] newarray = GenerateNewArray(array, array.Length/2);
    PrintArray(newarray);
}
else
{
    int[] newarray = GenerateNewArray(array, array.Length/2 + 1);
    PrintArray(newarray);
}


int[] GenerateArray(int lenght)
{
    int[] array = new int[lenght];

    Random random = new Random();

    for (int i = 0; i< lenght; i++)
    {
        array[i] = random.Next(-9, 10);
    }

    return array;
}


int[] GenerateNewArray(int[] array, int lenght)
{
    int[] newarray = new int[lenght];

    for (int i = 0; i < lenght; i++)
    {
        if (newarray.Length % 2 == 0)
        {
            newarray[i] = array[i] * array[array.Length - i - 1];
        }
        else
        {
            if (i != (lenght - 1))
            {
                newarray[i] = array[i] * array[array.Length - i - 1];
            }
            else
            {
                newarray[i] = array[i];
            }
        }
        
    }

    return newarray;
}


void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}
