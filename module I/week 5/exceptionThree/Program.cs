try
{
    string text = "Teste";

    int number = Convert.ToInt32(text);

    int result = 100 / number;

    Console.WriteLine($"The result of 100 divided by {number} is: {result}");
}
catch (DivideByZeroException exDivideByZero)
{
    Console.WriteLine($"Error Explanation: {exDivideByZero.Message}");
}
catch (FormatException exFormat)
{
    Console.WriteLine($"Error Explanation: {exFormat.Message}");
}
catch (Exception exGeneral)
{
    Console.WriteLine($"Catch Error: {exGeneral}");
}
finally
{

}