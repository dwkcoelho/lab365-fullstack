// Library import

// Class name

// Declaration of methods

// Declaration of variables
using System.Linq.Expressions;

int option, firstNumber, secondNumber;
float result;
// Input
Console.WriteLine("Write the first number:");
firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Write the second number:");
secondNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Choose an operation: \n 1- Sum \n 2- Subtraction \n 3- Division \n 4- Multiplication \n 5- Exit \n" +
    "Enter the chosen option:");
option = int.Parse(Console.ReadLine());
// Processing
switch(option) {
    case 1:
        Console.WriteLine("Sum operation: \n");
        result = firstNumber + secondNumber;
        Console.WriteLine(result);
        break;
    case 2:
        Console.WriteLine("Subtraction operation: \n");
        result = firstNumber - secondNumber;
        Console.WriteLine(result);
        break;
    case 3:
        Console.WriteLine("Division operation: \n");
        result = firstNumber / secondNumber;
        Console.WriteLine(result);
        break;
    case 4:
            Console.WriteLine("Multiplication operation: \n");
        result = firstNumber * secondNumber;
        Console.WriteLine(result);
        break;
    case 5:
        Console.WriteLine("Exit system");
        break;
}

// Output