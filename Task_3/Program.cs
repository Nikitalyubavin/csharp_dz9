/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Clear();
int number1 = UserInput("Введите неотрицательное целое число M: ", "Введено неверное значение!");
int number2 = UserInput("Введите неотрицательное целое число N: ", "Введено неверное значение!");

int count = 1;
int result = AkkermanFunction(number1, number2);
if (result == -1) Console.WriteLine("Превышен лимит вызовов рекурсии.");
else Console.WriteLine($"M = {number1}, N = {number2} -> A({number1}, {number2}) = {AkkermanFunction(number1, number2)}");





int AkkermanFunction(int num1, int num2)
{
    count++;
    if (count > 15000) return -1;
    if (num1 == 0) return num2 + 1;
    else if (num1 != 0 && num2 == 0) return AkkermanFunction(num1 - 1, 1);
    else return AkkermanFunction(num1 - 1, AkkermanFunction(num1, num2 - 1));
}

int UserInput(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine()??"", out int number) && number >= 0) return number;
        else Console.WriteLine(errorMessage);
    }
}