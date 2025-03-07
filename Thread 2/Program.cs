using System;
using System.Threading;

class Program
{
    
    static void RecursiveMethod(object depthObj)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        int depth = (int)depthObj;
        Console.WriteLine($"Потік ID: {Thread.CurrentThread.ManagedThreadId}, Глибина: {depth}");

        if (depth > 0)
        {
            Thread newThread = new Thread(RecursiveMethod);
            newThread.Start(depth - 1);
        }
    }

    static void Main()
    {
        Console.WriteLine("Початок роботи програми...");
        RecursiveMethod(5);
        Console.WriteLine("Головний потік завершився.");
    }
}
