using System;

class Program
{
    static void Main(string[] args)
    {
        // Create object
        ParameterDemo pd = new ParameterDemo();

        // 1. Call Increase(ref int)
        int num = 20;
        pd.Increase(ref num);
        Console.WriteLine("After Increase: " + num);

        // 2. Call GetFullName(out string)
        string fullName;
        pd.GetFullName(out fullName);
        Console.WriteLine("Full Name: " + fullName);

        // 3. Call SumAll(params int[])
        int total = pd.SumAll(5, 10, 15, 20);
        Console.WriteLine("Sum of all numbers: " + total);
    }
}
