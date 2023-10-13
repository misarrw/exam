// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System.Dynamic;

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

string ShowNumbers(int num)
{
    if(num == 1) return "1";
    else return $"{num}, " + ShowNumbers(num-1);

}

Console.Write(ShowNumbers(N));