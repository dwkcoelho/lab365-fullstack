try
{
    string text = null; 
    if (text.Length > 0)    
    { 
        Console.WriteLine($"Amount of characters: {text.Length}");
    }
}
catch (NullReferenceException exNull)
{
    Console.WriteLine($"Error Explanation: {exNull.Message}.\nDo this to get out of this error!");
}
catch (Exception exGeneral)
{
    Console.WriteLine($"Catch Error: {exGeneral}");
}
finally
{

}