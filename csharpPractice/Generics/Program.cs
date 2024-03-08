using Generics;

// A<int, int> a = new A<int, int>(10, 20);
Point<int, int> p1 = new Point<int, int>(10, 20);
Point<int, int> p2 = new Point<int, int>(10, 20);

Point<int, int> sum = p1.Add(p2);
Console.WriteLine(sum.x);
Console.WriteLine(sum.y);