// Задача 1: Задайте значение N. Напишите программу, которая выведет все четные натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

void EvenNums(int a)
{
    if (a == 0) return;
    if (a % 2 == 0)
    {
        System.Console.Write($"{a} ");
        EvenNums(a - 2);
    }
    else
    {
        a = a - 1;
        System.Console.Write($"{a} ");
        EvenNums(a - 2);
    }
}

EvenNums(int.Parse(Console.ReadLine()));

// // Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
// // чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// // M = 1; N = 5 -> "2, 4"
// // M = 4; N = 8 -> "4, 6, 8"

// void Numbers(int m, int n)
// {
//     if (m > n) return;
//     if (m % 2 == 0)
//     {
//         Console.Write($" {m} ");
//     }
//     Numbers(++m, n);
// }

// Console.Write("Write number 1: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Write number 2: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Numbers(m, n);