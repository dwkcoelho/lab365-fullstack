using geometricFigure.Class;

Circle circle = new Circle();
Triangle triangle = new Triangle();
Square square = new Square();

circle.Radius = 4;
Console.WriteLine(circle.Area());
Console.WriteLine(circle.Perimeter());

square.Side = 10;
Console.WriteLine(square.Area());
Console.WriteLine(square.Perimeter());

triangle.Height = 15;
triangle.Base = 20;
triangle.ASide = 10;
triangle.BSide = 20;
triangle.CSide = 10;
Console.WriteLine(triangle.Area());
Console.WriteLine(triangle.Perimeter());
