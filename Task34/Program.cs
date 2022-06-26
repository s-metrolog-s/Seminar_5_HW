// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[8];

Console.Clear();
Console.WriteLine("************************************************************");
Console.WriteLine($"Дан массив из {array.Length} элементов");

MakeArray(array);
PrintArray(array);
Console.WriteLine("Считаем количество четных чисел в массиве...");
Console.WriteLine($"Количество четных чисел равно: {CountEvenNumber(array)}");

int CountEvenNumber(int[] currentArray)
{
    int count = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void MakeArray(int[] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(100, 1000);
    }
}

void PrintArray(int[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write($"{currentArray[i]} \t");
    }
     Console.WriteLine();
}

Console.WriteLine("************************************************************");