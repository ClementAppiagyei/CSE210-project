using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");


        int x = 4;
        int y = 2;
            if (x > y)
            {
                Console.WriteLine($"The answer is {x}");
            }

             string firstName = "58";
             int num = int.Parse(firstName);
             Console.WriteLine(num);
    }

}