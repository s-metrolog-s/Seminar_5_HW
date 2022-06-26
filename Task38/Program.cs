// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Random rand = new Random();
double[] array = new double[rand.Next(4, 10)];

Console.Clear();
Console.WriteLine("******************************************************************");
Console.WriteLine($"Дан случайный массив из {array.Length} элементов:");

MakeArray(array);
PrintArray(array);

Console.WriteLine("Находим разницу между максимальным и минимальным элементом...");
Console.WriteLine($"Разница равна: {Math.Round(MinMaxDiff(array), 2)}");

void MakeArray(double[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = Math.Round((rand.NextDouble() + rand.Next(1, 10)),2);
    }
}

void PrintArray(double[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write($"{currentArray[i]} \t");
    }
    Console.WriteLine();
}

double MinMaxDiff(double[] currentArray)
{
    double diff = 0;
    double max = currentArray[0];
    double min = currentArray[0];

    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] > max) max = currentArray[i];
        else if (currentArray[i] < min) min = currentArray[i];

        diff = max - min;
    }
    return diff;
}


Console.WriteLine("******************************************************************");