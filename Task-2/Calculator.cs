public class Calculator
{
    // 1. Void method that prints a message
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    // 2. Add method
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // 3. Multiply method with optional parameter
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}
