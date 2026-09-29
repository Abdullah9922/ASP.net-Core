

using Generic_Box__Practice_;

Box<int> b1 = new Box<int>(23);
b1.Print();
Box<string> b2 = new Box<string>("Kola");
b2.Print();
Box<double> b3 = new Box<double>(12.2154);
b3.Print();

// Generic methord
b3.GenericPrint(10);
b3.GenericPrint("Hello");
b3.GenericPrint(10.25);
b3.GenericPrint(true);

// multiple Generics
Pair<int, string> p1 = new Pair<int, string>(23, "Korim");
p1.Print();
Pair<string, double> p2 = new Pair<string, double>("Rohim", 2.56);
p2.Print();
Pair<int, bool> p3 = new Pair<int, bool>(23, true);
p2.Print();
