/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Clear();

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(PrintSumNumbers(m, n));

int PrintSumNumbers(int m, int n)
{
    if (n == m)
    {
        //Console.WriteLine(m);
        return m;
    }
    int s = PrintSumNumbers(m, n - 1) + n;
    //Console.WriteLine(s);
    return s;
}