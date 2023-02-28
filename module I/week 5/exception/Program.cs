using exceptions.Class;

try
{
    // Handling data of another type.
    Console.WriteLine("Write a number:");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine($"The result is {number} x 10 is: {number * 10}");
}
catch (FormatException ex)
{
    Console.WriteLine($"\nSpecific Error Caught: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Caught Error: {ex}");
}
finally
{
    Console.WriteLine("\nYou need to write a number!");
}