//Declaration of variables
List <string> fruits= new List<string>();
bool goahead = true;

//Input
Console.WriteLine("Make a fruit list with up to fifteen itens: ");


while (goahead)
{
    if (fruits.Count() == 15)
    {
        goahead = false;
        break;
    }

    Console.Write("Insert a fruit: ");
    fruits.Add(Console.ReadLine());
    Console.Write("Do you want to add some more fruit? (Yes/No) \n");
    string answer = Console.ReadLine();

    if (answer == "No" || answer == "no" || answer == "NO")
    {
        goahead = false;
    }
}
//Output
fruits.Sort();
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}