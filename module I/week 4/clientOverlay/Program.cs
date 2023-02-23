using client.Class;


Client diegoAlegre = new Client("Diego", DateTime.Parse("1996-02-02"), new Address()
{
    PublicPlace = "Your street",
    Number = "XX",
    State = "Your state",
    City = "Your city",
    Country = "Your country",
    ZipCode = "XXXXXXXXX"
}, "Apple");
Console.WriteLine(diegoAlegre.Store);

Employee diogoAlegre = new Employee("Diogo", DateTime.Parse("2000-05-30"), new Address()
{
    PublicPlace = "Your street",
    Number = "XX",
    State = "Your state",
    City = "Your city",
    Country = "Your country",
    ZipCode = "XXXXXXXXX"
},
    (decimal)1500.00, "Manager");


Console.WriteLine(diegoAlegre.Birth);
diegoAlegre.HaveBirthday();
Console.WriteLine(diegoAlegre.Birth);

Console.WriteLine(diogoAlegre.Salary);
Console.WriteLine(diogoAlegre.Birth);
diogoAlegre.HaveBirthday();
Console.WriteLine(diogoAlegre.Birth);
Console.WriteLine(diogoAlegre.Salary);

