using System;

class Program
{
    static void DisplayWelcome() {
        Console.WriteLine("Welcome to the Program");
    }           
    
    // I will recive a string, this is why I use static string
    static string PromptUserName() {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    // Same idea with the int
    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Same idea the one before
    static int SquareNumber(int number) {
        int squareNumber = number * number;
        return squareNumber;
    }

    static void DisplayResults(string userName, int squareNumber) {
        Console.WriteLine($"{userName}, the square number of your number is {squareNumber}");
    }

    // Attention on how to declare the functions here
    // type returner = functions name
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        DisplayResults(userName, squareNumber);
    }

}
