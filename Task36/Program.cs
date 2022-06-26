// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Random rand = new Random();
int[] array = new int[rand.Next(4, 10)];

Console.Clear();
Console.WriteLine("************************************************************");
Console.WriteLine($"Дан случайный массив из {array.Length} элементов:");

MakeArray(array);
PrintArray(array);

Console.WriteLine("Находим сумму элементов, стоящих на нечетных позициях...");
Console.WriteLine($"Сумма нечетных элементов равна: {SumOddPos(array)}");

void MakeArray(int[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(1, 100);
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

int SumOddPos(int[] currentArray)
{
    int sum = 0;
    for (int i = 1; i < currentArray.Length; i = i + 2)
    {
        sum = sum + currentArray[i];
    }
    return sum;
}

Console.WriteLine("************************************************************");