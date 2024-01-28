using System;
class Program
{
    static void Main(string[] args)
    {
        int sr = 0;
        int[] mas = { 1, 2, 3, 4, 5 };
        int sum = mas.Sum();
        sr = sr + sum;
        sr = sr / 5;
        Console.WriteLine("Сумма элементов массива: " + sum);
        Console.WriteLine("Среднее арифметическое: " + sr);

    }
}