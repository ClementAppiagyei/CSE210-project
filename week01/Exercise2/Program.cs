using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pick a number between (1-5): ");
        string numberPicked = Console.ReadLine();

        int a = int.Parse(numberPicked);

        if (a == 1)
        {
            Console.WriteLine("Congratulations You Won!!! 🍾🎉🎊");
            Console.Write("Claim Your Price Now!!");
        }
        else
        {
            Console.WriteLine("Sorry 😒😒, Try again next time!");
        }
    }
}