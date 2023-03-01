decimal x = 2;
decimal y = 0;

try
{
    Console.WriteLine($"x / y is equal: {x / y}");
}
catch (DivideByZeroException exDivideByZero)
{
    Console.WriteLine($"Explanation of the divide by zero error: {exDivideByZero.Message}");
}
catch (ArithmeticException exArithmetic)
{
    Console.WriteLine($"Error Explanation: {exArithmetic.Message}");
}
catch (Exception exGeneral)
{
    Console.WriteLine($"Catch Error: {exGeneral.Message}");
}