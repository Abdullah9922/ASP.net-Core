using Practice_Generics__Easy_;

// int
GenericBox<int> intBox = new GenericBox<int>(100);
intBox.Display();
intBox.SetValue(500);
Console.WriteLine(intBox.GetValue());

// string
GenericBox<string> nameBox = new GenericBox<string>("Asif");
nameBox.Display();
nameBox.SetValue("korim");
Console.WriteLine(nameBox.GetValue());

// double
GenericBox<double> priceBox = new GenericBox<double>(99.99);
priceBox.Display();
priceBox.SetValue(100.02);
Console.WriteLine(priceBox.GetValue());

