using System;

class Program
{
    static void Main(string[] args)
    {
          Console.Write("Insert the grade: ");
        // Attach the input to a string
        string input = Console.ReadLine();
        // Convert the string to an int
        int grade = int.Parse(input);

        string finalGrade = "";
        string signal = "";

        // Starts the conditionals for the grade
        if (grade >= 90) {
            finalGrade = "A";
        }
        else if (grade >= 80) {
            finalGrade = "B";
        }
        else if (grade >= 70) {
            finalGrade = "C";
        }
        else if (grade >= 60) {
            finalGrade = "D";
        }
        else if (grade < 60) {
            finalGrade = "F";
        }

        // Creating the system to set the + or - and treating the execptions.
        int lastDigit = grade % 10;
        // Last digit, not A or F and not F for the second
        if (lastDigit >= 7 && finalGrade != "A" && finalGrade!= "F") {
            signal = "+";
        } else if (lastDigit <= 3 && finalGrade!= "F") {
            signal = "-";
        } else {
            signal = "";
        }

        if (grade >= 70) {
            Console.WriteLine($"Congratulations, you passed. Your grade was {finalGrade}{signal}");
        } else {
            Console.WriteLine($"You have not been approved, your grade was {finalGrade}");
        }
    }
}
