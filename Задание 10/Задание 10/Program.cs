using System;

class Program
{
    static void Main()
    {
        string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};
        Console.Write("Введите число: ");
        string input = Console.ReadLine();
        bool found = false;
        foreach (string str in arr)
        {
            if (str == input)
            {
                found = true;
                break;
            }
        }
        if (found)
        {
            Console.WriteLine("Строка найдена");
        }
        else
        {
            Console.WriteLine("Строка не найдена");
        }
    }
}