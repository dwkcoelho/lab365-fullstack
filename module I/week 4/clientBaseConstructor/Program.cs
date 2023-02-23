using client.Class;


Client diegoAlegre = new Client("Diego", DateTime.Parse("1996-02-02"), "Apple");
Console.WriteLine(diegoAlegre.Store);

Employee diogoAlegre = new Employee("Diogo", DateTime.Parse("2000-05-30"), (decimal)1500.00);
Console.WriteLine(diogoAlegre.Salary);
diogoAlegre.ReceiveRaise((decimal)1500.00);
Console.WriteLine(diogoAlegre.Salary);
