/*Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа
 в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

int InputInt(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}
(int a, int b) CheckNumbers(int m, int n)
{
    if (m > n)
    {
        int buffer = m;
        m = n;
        n = buffer;
    }
    return (m, n);
}
void ShowNumbers(int a, int b)
{
    if (a > b)
    {
        return;
    }
    if (b % 2 == 0)
    {
        ShowNumbers(a, b - 2);
        System.Console.Write($"{b} ");
    }
    else
    {
        b--;
        ShowNumbers(a, b - 2);
        System.Console.Write($"{b} ");
    }
}

Console.Clear();
int m = InputInt("Введите число M > ");
int n = InputInt("Введите число N > ");
(m, n) = CheckNumbers(m, n);
ShowNumbers(m, n);