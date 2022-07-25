// Задача 2. На вход подаются два числа случайной длины. 
// Найдите произведение каждого разряда первого числа на каждый разряд второго. 
// Ответ запишите в массив.

// 24, 132 -> {2, 6, 4, 4, 12, 8}

Console.Clear();
Console.WriteLine("***************************************************");
Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int[] firstArray = new int[CheckCountNumbers(number1)];
int[] secondArray = new int[CheckCountNumbers(number2)];
int[] resultArray = new int[firstArray.Length * secondArray.Length];

MakeArray(firstArray, number1);
MakeArray(secondArray, number2);

ArrayMult(firstArray, secondArray, resultArray);

Console.WriteLine("Считаем произведения каждого разряда двух чисел...");
Console.Write($"Произведения разрядов чисел {number1} и {number2} равны: ");

PrintArray(resultArray);

Console.WriteLine("***************************************************");

void MakeArray (int[] currentArray, int number)
{
    int count = currentArray.Length - 1;
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = number / Convert.ToInt32(Math.Pow(10, count));
        number = number % Convert.ToInt32(Math.Pow(10, count));
        count--;
    }
}

void PrintArray (int[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write(currentArray[i] + " ");
    }
    Console.WriteLine();
}

void ArrayMult (int[] firstArray, int[] secondArray, int[] resultArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        for (int j = 0; j < secondArray.Length; j++)
        {
            resultArray[count] = firstArray[i] * secondArray[j];
            count++;
        }
    }

}

int CheckCountNumbers (int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}