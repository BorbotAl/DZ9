// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Веедите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num1, int num2)
{
    if (num1 == num2)
    {
        Console.Write('"');
        Console.Write($"{num1}, ");
        num1 = num1 - 1;
    }
    if (num1 > 1)
    {
        Console.Write($"{num1}, ");
        NaturalNumbers(num1 - 1, num2);
    }
    else
    {
        Console.Write(num1);
        Console.WriteLine('"');
    }
}

if (number > 0)
{
    if (number == 1)
    {
        Console.Write('"');
        Console.Write($"{number}");
        Console.WriteLine('"');
    }
    else NaturalNumbers(number, number);
}
else Console.WriteLine("Введенное число не является натуральным");