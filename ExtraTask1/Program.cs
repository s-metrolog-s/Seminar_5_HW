// Задача 1. Задан массив из случайных цифр на 15 элементов. 
// На вход подаётся трёхзначное натуральное число. 
// Напишите программу, которая определяет, есть в массиве последовательность 
// из трёх элементов, совпадающая с введённым числом.
// {0, 5, 6, 2, 7, 7, 8, 1, 1, 9} - 277 -> да
// {4, 4, 3, 6, 7, 0, 8, 5, 1, 2} - 812 -> нет

int[] mainArray = new int[15];

Console.Clear();
Console.WriteLine("Дан массив из 15 элементов");
Console.WriteLine("***************************************************");

MakeArray(mainArray);
PrintArray(mainArray);

Console.WriteLine();
Console.WriteLine("Введите трехзначное число:");

string number = Console.ReadLine();
string numberChecked = CheckInput(number); // Введем проверку числа по условию

Console.WriteLine("***************************************************");
Console.WriteLine($"Проверим наличие комбинации {numberChecked} в массиве...");

CheckSubsequence(mainArray, Convert.ToInt32(numberChecked));

Console.WriteLine("***************************************************");

void MakeArray (int[] currentArray)
{
    Random rand = new Random();
    for (int i = 0; i < currentArray.Length; i++)
    {
        currentArray[i] = rand.Next(1, 10);
    }
}

void PrintArray (int[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write(currentArray[i] + " ");
    }
}

void CheckSubsequence (int[] currentArray, int number)
{
    bool flag = false;
    int firstPosition = currentArray[0];
    for (int i = 0; i < currentArray.Length - 2; i++)
    {
        if ((currentArray[i] == number / 100) &&
            (currentArray[i + 1] == (number / 10) % 10) &&
            (currentArray[i + 2] == (number % 100) % 10))
        {
            firstPosition = i;
            flag = true;
        }
    }
    if (!flag) Console.WriteLine($"Последовательность {number} не найдена");
    else 
    {
        Console.WriteLine($"Последовательность {number} найдена и располагается на: ");
        Console.WriteLine($"{firstPosition + 1}, {firstPosition + 2}, {firstPosition +3} элементах массива");
    }
}

string CheckInput (string number)
{
    if (((Convert.ToInt32(number) >= 100) && (Convert.ToInt32(number) < 999)))
    {
        Console.WriteLine("Число принято");
        return number;
    }
    else 
    {
        Console.WriteLine("Введите трехзначное число:");
        number = Console.ReadLine();
        return CheckInput(number);
    }
}
