using System;

class Program
{
    static void Main(string[] args)
    {
        // Create object of Calculator
        Calculator calc = new Calculator();

        // Call PrintWelcome()
        calc.PrintWelcome();

        // Call Add()
        int sum = calc.Add(5, 10);
        Console.WriteLine("Addition (5 + 10) = " + sum);

        // Call Multiply() with both parameters
        int mul1 = calc.Multiply(5, 3);
        Console.WriteLine("Multiplication (5 * 3) = " + mul1);

        // Call Multiply() using default value (num2 = 1)
        int mul2 = calc.Multiply(7);
        Console.WriteLine("Multiplication using default value (7 * 1) = " + mul2);
    }
}
