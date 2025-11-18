using System;

class Program
{
    static void Main(string[] args)
    {
        // Create two objects of Student
        Student s1 = new Student();
        Student s2 = new Student();

        // Assign different values
        s1.name = "Sakshyam";
        s1.age = 20;
        s1.address = "Biratnagar";

        s2.name = "David";
        s2.age = 22;
        s2.address = "Damak";

        // Display instance fields
        Console.WriteLine("Student 1:");
        Console.WriteLine($"Name: {s1.name}, Age: {s1.age}, Address: {s1.address}");

        Console.WriteLine("\nStudent 2:");
        Console.WriteLine($"Name: {s2.name}, Age: {s2.age}, Address: {s2.address}");

        // Print static field
        Console.WriteLine("\nSchool Name (Static Field): " + Student.schoolName);
    }
}
