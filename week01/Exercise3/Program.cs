using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;
        while (playAgain) {
            // Generating a random number
            Random random = new Random();
            // Creating the magic number and creating the range
            int magicNumber = random.Next(0, 10);
            int guess = -1;
            int counter = 1;

            // Creating while and if
            while (guess != magicNumber) {

                // Creating the guessing
                Console.Write("Guess the magic number: ");
                // Not using int here because its already declarated outside
                guess = int.Parse(Console.ReadLine());

                if (guess > magicNumber) {
                    Console.WriteLine("Lower");
                    counter++;
                } else if (guess < magicNumber) {
                    Console.WriteLine("Higher");
                    counter++;
                } else {
                    Console.WriteLine($"Congratulations, you found the magic number in {counter} trys!");
                    counter++;
                }
            }
             Console.Write("Do you want to play again? (S/N)");
            string answer = Console.ReadLine().ToUpper();
            playAgain = answer == "S";
        }
        Console.WriteLine("Thanks for playing");
    }
}
