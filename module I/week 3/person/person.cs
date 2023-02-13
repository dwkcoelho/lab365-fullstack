
using person.Class;

Person firstPerson = new Person();
Console.WriteLine(firstPerson);

Person secondPerson = new Person("Karol");
Console.WriteLine($"The person's name is {secondPerson.name}");

Person thirdPerson = new Person(26);
Console.WriteLine($"The person's age is {thirdPerson.age}");

Person fourthPerson = new Person(1.72f);
Console.WriteLine($"The person's height is {fourthPerson.height}");

Person fifthPerson = new Person("José", 22);
Console.WriteLine($"The person's name is {fifthPerson.name} and your age is {fifthPerson.age}");

Person sixthPerson = new Person("Willian", 1.80f);
Console.WriteLine($"The person's name is {sixthPerson.name} and your height is {sixthPerson.height}");

Person seventhPerson = new Person(28, 1.78f);
Console.WriteLine($"The person's age is {seventhPerson.age} and your height is {seventhPerson.height}");

Person eighthPerson = new Person("Diego", 26, 1.86f);
Console.WriteLine($"The person's name is {eighthPerson.name}, your age is {eighthPerson.age} " +
    $"and your height is {eighthPerson.height}");