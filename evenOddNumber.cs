List<int> listNumbers = new List<int>();
List<int> oddNumbers = new List<int>();
List<int> evenNumbers = new List<int>();

Console.WriteLine("Write ten numbers:");
for(int i = 0;i < 10; i++)
{
    listNumbers.Add(int.Parse(Console.ReadLine()));
}
foreach (int number in listNumbers)
{
    if (number % 2 == 0)
    {
        evenNumbers.Add(number);
    } else
    {
        oddNumbers.Add(number);
    }
}
oddNumbers.Sort();
Console.Write("\nAscending list of odd numbers: |");
foreach (int odd in oddNumbers)
{
    Console.Write(odd + "|");
}
Console.WriteLine("\nThe list of odd numbers has " + oddNumbers.Count() +
    " numbers and their sum is equal to " + oddNumbers.Sum());

evenNumbers.Sort();
Console.Write("\nAscending list of even numbers: |");
foreach (int even in evenNumbers) 
{
        Console.Write(even + "|");
}
Console.WriteLine("\nThe list of even numbers has " + evenNumbers.Count() +
    " numbers and their sum is equal to " + evenNumbers.Sum());