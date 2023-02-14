/*Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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
int SumNumbers(int a, int b)
{
    if (b < a)
    {
        return 0;
    }
    return SumNumbers(a, b - 1) + b;
}

Console.Clear();
int m = InputInt("Введите число M > ");
int n = InputInt("Введите число N > ");
(m, n) = CheckNumbers(m, n);
System.Console.WriteLine(SumNumbers(m, n));