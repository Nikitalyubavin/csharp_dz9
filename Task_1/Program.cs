/* Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();
int number = UserInput("Введите целое число N: ", "Введено неверное значение!");
Console.Write($"N = {number} -> ");
NaturalNumbers(number);



void NaturalNumbers(int num)
{
    if (num > 1)
    {
        Console.Write($"{num}, ");
        NaturalNumbers (num - 1);
    }
    else Console.WriteLine("1");
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