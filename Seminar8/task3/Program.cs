int[,] array = new int[,]
{
    {1, 2, 3},
    {4, 5, 6},
    {1, 2, 3},
    {7, 8, 9}
};

Dictionary<int, int> frequency = new Dictionary<int, int>();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int element = array[i, j];

        if (frequency.ContainsKey(element))
        {
            frequency[element]++;
        }
        else
        {
            frequency.Add(element, 1);
        }
    }
}

foreach (KeyValuePair<int, int> pair in frequency)
{
    Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
}