using client.Class;


Client diegoAlegre = new Client();
diegoAlegre.Name = "Diego";
Console.WriteLine(diegoAlegre.Name);
diegoAlegre.Store = "Apple";
Console.WriteLine(diegoAlegre.Store);

Employee diogoAlegre = new Employee((decimal)1500.00);
diogoAlegre.Name = "Diogo";
Console.WriteLine(diogoAlegre.Salary);
diogoAlegre.ReceiveRaise((decimal)1500.00);
Console.WriteLine(diogoAlegre.Salary);
