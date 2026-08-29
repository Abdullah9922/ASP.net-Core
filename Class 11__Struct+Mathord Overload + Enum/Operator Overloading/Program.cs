using Operator_Overloading;

Point p1 = new Point { X = 2, Y = 3 };
Point p2 = new Point { X = 4, Y = 5 };

Point p3 = p1 + p2;

Console.WriteLine(p3.X);
Console.WriteLine(p3.Y);