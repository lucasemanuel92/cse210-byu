using System;

class Program
{
    static void Main(string[] args)
    {
 // Initializing the variables and list
        List<int> toAdd = new List<int>();
        int numbers = -1;

        // Creating the input and the lace
        while (numbers != 0) {
            Console.WriteLine("Insert the number you want to add or 0 to exit: ");
            string provisory = Console.ReadLine();
            numbers = int.Parse(provisory);

            if (numbers != 0) {
                toAdd.Add(numbers);
            }
        }

        // Creating the sum
        int sum = 0; 
        foreach (int i in toAdd) {
            sum += i;
        }

        // Creating the average
        float average = 0;
        // Verifying if there are numbers to make the average calculations
        if (toAdd.Count > 0) {
            average = sum / (float)toAdd.Count;
        }

        // Fiding the max number
        int maxNumber = toAdd.Max();

        // Printing the messages
        Console.WriteLine($"The sum is {sum}" );
        Console.WriteLine($"The average is: {average}");
        // Using a different manner
        Console.WriteLine("The largest number is :" + maxNumber);

        // STRETCH
        int smallPositive = int.MaxValue;
        foreach (int i in toAdd) {
            if (i > 0 && i < smallPositive) {
                smallPositive = i;
            } 
        }
        Console.WriteLine($"The smallest positive number is {smallPositive}");
        
        toAdd.Sort();
        foreach (int i in toAdd) {
            Console.Write(i + " ");
        }
    }
}
