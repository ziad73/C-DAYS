using System;

public class Program
{
    public static void IsEven()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        string str = number % 2 == 0 ? "even" : "odd";
        Console.WriteLine("The number is " + str);
    }

    public static void IsPositive()
    {
        Console.Write("Enter a number: ");
        double number = double.Parse(Console.ReadLine());
        if (number == 0)
        {
            Console.WriteLine("The number is zero.");
        }
        else if (number > 0)
        {
            Console.WriteLine("The number is positive.");
        }
        else
        {
            Console.WriteLine("The number is negative.");
        }
    }

    public static void IsSquare()
    {
        Console.Write("Enter the length of the rectangle: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());

        bool isSquare = length == width;
        if (isSquare)
        {
            Console.WriteLine("The rectangle is a square.");
        }
        else
        {
            Console.WriteLine("The rectangle is not a square.");
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Select a program to run:");
        Console.WriteLine("1. Check if number is even/odd");
        Console.WriteLine("2. Check if number is positive/negative/zero");
        Console.WriteLine("3. Check if rectangle is square");
        Console.Write("Enter your choice (1-3): ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                IsEven();
                break;
            case "2":
                IsPositive();
                break;
            case "3":
                IsSquare();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}