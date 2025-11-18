using System;

// ---------- PART 1: ENUM + USER INPUT ----------
Console.Write("Enter a day: ");
string day = Console.ReadLine();

DayType type;

// Check weekend (Friday or Saturday)
if (day.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
    day.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
{
    type = DayType.Weekend;
}
else
{
    type = DayType.Weekday;
}

Console.WriteLine("It is: " + type);


// ---------- PART 2: RECORD + WITH EXPRESSION ----------
Book book1 = new Book("Harry Potter", "J.K. Rowling", 999.99);

// Create new object with changed title & price using with expression
Book book2 = book1 with { title = "Lord of the Rings", price = 799.50 };

// Print first object
Console.WriteLine("\nBook 1:");
Console.WriteLine($"Title: {book1.title}, Author: {book1.author}, Price: {book1.price}");

// Deconstruct second object
var (title2, author2, price2) = book2;

Console.WriteLine("\nBook 2 (Deconstructed):");
Console.WriteLine($"Title: {title2}, Author: {author2}, Price: {price2}");
