using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage: ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);

        if (x >= 90)
        {
            Console.WriteLine('A');
        }
        else if (x >= 80 && x <= 89.9)
        {
            Console.WriteLine('B');
        }
        else if (x >= 70 && x <= 79.9)
        {
            Console.WriteLine('C');
        }
        else if (x >= 60 && x <= 69.9)
        {
            Console.WriteLine('D');
        }
        else if (x < 60)
        {
            Console.WriteLine('F');
        }
        
        if (x >= 70)
        {
            Console.WriteLine("Congratulations");
        }

    }
}