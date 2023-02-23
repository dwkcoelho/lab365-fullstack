using client.Class;

//Upcasting
Person diegoAlegre = new Client("Diego", DateTime.Parse("1996-02-02"), new Address()
{
    PublicPlace = "Your street",
    Number = "XX",
    State = "Your state",
    City = "Your city",
    Country = "Your country",
    ZipCode = "XXXXXXXXX"
}, "Apple");

//Console.WriteLine(diegoAlegre.Store); - It dont work.

//Downcasting

Client clientDiegoAlegre = (Client)diegoAlegre;
Console.WriteLine(clientDiegoAlegre.Store);




