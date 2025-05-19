using System;

class Program
{
    static void Main(string[] args)
    {
        // Initinal message
        Journal journal = new Journal();
        Console.WriteLine("Welcome to Your Personal Journal");

        // Creating a system to offer the options for the user
        bool running = true;
        while (running)
        {
            Console.WriteLine("What you want to do today? ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Select");
            int option = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // After the choice, what to display
            switch (option)
            {
                case 1:
                    journal.NewEntry();
                    Console.WriteLine();
                    break;
                case 2:
                    journal.Display();
                    Console.WriteLine();
                    break;
                case 3:
                    Console.Write("Enter the file name you want to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.Load(loadFileName);
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Write("Enter the file name you want to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.Save(saveFileName);
                    Console.WriteLine("Saved!");
                    Console.WriteLine();
                    break;
                case 5:
                    running = false;
                    Console.WriteLine("See you soon");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid input. Try again");
                    break;
            }
        }
    }
}