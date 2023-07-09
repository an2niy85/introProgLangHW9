/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.Clear();
Console.WriteLine("Введите значение N: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintRowAhead(number));

string PrintRowAhead(int n)
{
    if (n == 1) return "1";
    else return n +", " + PrintRowAhead(n-1);
}