// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


///Метод вычисления функции Аккермана:
int FunctionAckerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m != 0 && n == 0)
    {
        return FunctionAckerman(m - 1, 1);
    }
    if (m > 0 && n > 0)
    {
        return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
    }
    return FunctionAckerman(m, n);
}

Console.Write("Введите начальное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите начальное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Функция Аккермана для чисел A({m},{n}) = {FunctionAckerman(m, n)}");