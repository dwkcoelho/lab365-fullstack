using product.Class;

Product firstProduct = new Product("Calculator", 5.75, 100);

Product secondProduct = new Product();

Console.WriteLine($"First product is named: {firstProduct.name}" +
    $", price: {firstProduct.price}, amount: {firstProduct.amount}");

Console.WriteLine($"Second product is named: {secondProduct.name}" +
    $", price: {secondProduct.price}, amount: {secondProduct.amount}");
