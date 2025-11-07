using System;

class Program
{
    static void Main()
    {
        Random random = new Random(); 
        int number = random.Next(1, 101);
        Console.WriteLine(number);
    }
}
