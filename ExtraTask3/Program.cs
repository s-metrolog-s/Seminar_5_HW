// Задача 3. Найдите все числа от 1 до 1000000, 
// сумма цифр которых в три раза меньше их произведений. 
// Подсчитайте их количество.

int number = 444;

Console.WriteLine(CountNumbers(number));
Console.WriteLine(Sum(number, CountNumbers(number)));

int Sum (int number, int count)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + (number / Convert.ToInt32(Math.Pow(10, count)));
        number = number % Convert.ToInt32(Math.Pow(10, count));
        count--;
    }
    return sum;
}

int CountNumbers (int number)
{
    int index = 0;
    while (number > 0)
    {
        number = number / 10;
        index++;
    }
    return index;
}