using merchandise.Class;

Merchandise firstMerchandise = new Merchandise("Television", 1500.00f, 50);
firstMerchandise.DescribeMerchandise();
firstMerchandise.SetName("");
Console.WriteLine(firstMerchandise.GetName());