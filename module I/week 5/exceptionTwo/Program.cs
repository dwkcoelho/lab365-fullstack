public class Program
{
    public static void Main(string[] args)
    {
        FileInfo newFile = null;
        try
        {
            Console.WriteLine("Enter the name of the file you are going to create:");
            string nameFile = Console.ReadLine();

            newFile = new FileInfo(nameFile);

            using (StreamWriter fluxRecorder = File.AppendText(nameFile))
            {
                fluxRecorder.WriteLine("Text from inside the file.");
            }
        }
        catch (ArgumentException exArgument)
        {
            Console.WriteLine($"Error Explanation: {exArgument.Message}");
        }
        catch (Exception exGeneral)
        {
            Console.WriteLine($"Catch Error: {exGeneral.Message}");
        }
        finally
        {
            Console.WriteLine("Closing the program");
            newFile = null;
            
        }
    }
}
