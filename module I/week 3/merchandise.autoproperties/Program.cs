using merchandise.Class;

Merchandise firstMerchandise = new Merchandise("Television", 1500.00f, 50);
firstMerchandise.DescribeMerchandise();
Console.WriteLine(firstMerchandise.Name);
firstMerchandise.Name = "";
Console.WriteLine(firstMerchandise.Name);