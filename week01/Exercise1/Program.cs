using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates a box to insert the data 
       Console.Write("What is your first name? ");
       // Use the data inserted and create a type attached to it
       string firstName = Console.ReadLine();

       Console.Write("What is your last name? ");
       string lastName = Console.ReadLine();

       // Remember to use the "$" to use the {} in the console. 
       Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}
