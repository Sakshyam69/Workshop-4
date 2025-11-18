using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter marks: ");
        string inputMarks = Console.ReadLine();

        Console.Write("Enter total: ");
        string inputTotal = Console.ReadLine();

        // TryParse for safe input conversion
        if (int.TryParse(inputMarks, out int marks) &&
            int.TryParse(inputTotal, out int total))
        {
            // BREAKPOINT 1 HERE
            double percentage = marks / total * 100; // This line causes errpor due to integer division
            //double percentage = (double)marks / total * 100; // Corrected line with type casting


            // BREAKPOINT 2 HERE
            Console.WriteLine("Percentage = " + percentage);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter integers only.");
        }
    }
}
