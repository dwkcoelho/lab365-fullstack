// Declaration of Varibles
int[] primeNumber = new int[10];

//Input
for (int i = 0; i < 10; i++)
{
    Console.Write($"Write the {i + 1}° number: ");
    primeNumber[i] = int.Parse(Console.ReadLine());
}

//Processing
for (int i = 0; i < 10; i++)
{
    int count = 1;

    for (int j = 1; j < primeNumber[i]; j++)
    {
        if (primeNumber[i] % j == 0)
        {
            count++;
        }
        //Output
    }
    if (count == 2)
    {
        Console.WriteLine($"{primeNumber[i]} in the position {i} is a prime number!");
    }

}


