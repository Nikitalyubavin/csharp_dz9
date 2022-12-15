/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();
Console.WriteLine("Задайте диапазон от M до N.");
int number1 = UserInput("Введите целое число M: ", "Введено неверное значение!");
int number2 = UserInput("Введите целое число N: ", "Введено неверное значение!");

if (number1 < number2)
    Console.WriteLine($"M = {number1}, N = {number2} -> {SumNaturalNumbers(number1, number2)}");
else
{
    Console.WriteLine("Диапазон не может начинаться с большего числа. Программа автоматически переставит введенные числа местами.");
    Console.WriteLine($"N = {number2}, M = {number1} -> {SumNaturalNumbers(number2, number1)}");
}



int SumNaturalNumbers(int num1, int num2)
{
    if (num2 >= num1) return num1 += SumNaturalNumbers(num1 + 1, num2);
    else return 0;
}

int UserInput(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine()??"", out int number) && number > 0) return number;
        else Console.WriteLine(errorMessage);
    }
}