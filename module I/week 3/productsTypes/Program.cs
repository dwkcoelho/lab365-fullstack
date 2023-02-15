using productsTypes.Class;

Product firstProduct = new Product();

Console.WriteLine("Learning about Acess Modes:\n");

Console.WriteLine("Public Mode: \n");

firstProduct.name = "Calculator";
firstProduct.checkStock();
Console.WriteLine($"The name of the first product is {firstProduct.name}");
Console.WriteLine("Below will be the values ​​and actions of a child class\n");

Console.WriteLine("Protected Mode and Changing Private Properties \n");
 
CleaningProducts secondProduct= new CleaningProducts();
secondProduct.name = "Detergent";
secondProduct.checkStock();
secondProduct.acess();

