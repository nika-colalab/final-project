using System;

class Program
{
    static void Main()
    {
        Console.Write("First Number ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Second Number");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Opttion (+, -, *, /): ");
        string op = Console.ReadLine();

        double result = 0;

        if (op == "+")
            result = a + b;
        else if (op == "-")
            result = a - b;
        else if (op == "*")
            result = a * b;
        else if (op == "/")
            result = a / b;

        Console.WriteLine("Resuts: " + result);
    }
}
