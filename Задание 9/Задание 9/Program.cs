using System;
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("a: ");
        int a = int.Parse(Console.ReadLine());
        for (int i = 1; i < a; i+=2)
        
                Console.WriteLine("{0}", i);
        
    }
}