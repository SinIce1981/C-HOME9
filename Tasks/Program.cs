// Задача 64: Задайте значения M и N. Напишите рекурсивный метод,
// который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
FindNatural(n, m);
void FindNatural(int n, int a = 1)
{
    if (a % 3 == 0)
        Console.WriteLine(a);
    a++;

    if (a >= n)
    {
        return;
    }
    FindNatural(n, a);
}

