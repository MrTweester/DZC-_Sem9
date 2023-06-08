// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


void RoadToN(int m, int n, int sum)
{
    if (n < m)
    {
        System.Console.Write($"Сумма элементов: {sum}");
        return;
    }

    sum = sum + (m++);
    RoadToN(m, n, sum);
}

System.Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
RoadToN(m, n, 0);