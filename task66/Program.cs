// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumOfRange(int num1, int num2)
{
    int sumOfRange = 0;
    if (num1 < num2)
    {
        sumOfRange += num1 + SumOfRange(num1 + 1, num2);
    }
    else if (num1 > num2)
    {
        sumOfRange += num1 + SumOfRange(num1 - 1, num2);
    }
    else sumOfRange += num1;
    return sumOfRange;
}

int result = SumOfRange(numberM, numberN);
Console.WriteLine(result);