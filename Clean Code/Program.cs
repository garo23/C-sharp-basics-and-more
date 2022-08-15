// See https://aka.ms/new-console-template for more information

using SomeShapes;

  Triangle t1 = new Triangle();
    Triangle t2 = new Triangle();
    t1.Width = double.Parse(Console.ReadLine());
    t1.Length = double.Parse(Console.ReadLine());
    Console.WriteLine(t1.CalculateSurface());

