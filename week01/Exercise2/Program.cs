using System;

class Program
{
    static void Main(string[] args)
    {
    //     Console.WriteLine("Pick a number between (1-5): ");
    //     string numberPicked = Console.ReadLine();

    //     int a = int.Parse(numberPicked);

    //     if (a == 1)
    //     {
    //         Console.WriteLine("Congratulations You Won!!! 🍾🎉🎊");
    //         Console.Write("Claim Your Price Now!!");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Sorry 😒😒, Try again next time!");
    //     }

            Console.WriteLine("What is your grade percentage? ");
            string grade = Console.ReadLine();
            int e = int.Parse(grade);

            string letter;
            string symbol;
            int lastDigit = e % 10;


            if (e >= 90)
            {
                letter = "A";
            }
            else if (e >= 80)
            {
                letter = "B";
            }
            else if (e >= 70)
            {
                letter = "C";
            }
            else if (e >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }
            if (lastDigit >= 7)
            {
                symbol = "+";
            }
            else if (lastDigit < 3)
            {
                symbol = "-";
            }
            else
            {
                symbol = "";
            }
            if (letter == "A" && symbol == "+")
            {
                symbol = "";
            }

            if (letter == "F")
            {
                symbol = "";
            }

            Console.Write($"Your grade is: {letter}{symbol}");

            if (e >= 70)
            {
                Console.WriteLine("Congratulations you passed!!");
            }
            else
            {
                Console.WriteLine("Try Hard next time.");
            }
    }
}