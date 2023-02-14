/*Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/


int InputInt(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}
(int a, int b) CheckNumbers(int m, int n)
{
    if (m < 0) m = m * -1;
    if (n < 0) n = n * -1;
    return (m, n);
}
int ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return ackerman(m - 1, 1);
    }
    else
    {
        return (ackerman(m - 1, ackerman(m, n - 1)));
    }
}

Console.Clear();
int m = InputInt("Введите число M > ");
int n = InputInt("Введите число N > ");
(m, n) = CheckNumbers(m, n);
System.Console.WriteLine(ackerman(m, n));