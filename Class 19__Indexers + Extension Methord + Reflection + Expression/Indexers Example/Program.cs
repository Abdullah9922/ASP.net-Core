

using Indexers_Example;

Student student = new Student();

student[0] = "Asif"; // student.set_Item(0, "Asif");
student[1] = "Rahim";

Console.WriteLine(student[0]); // student.get_Item(0);
Console.WriteLine(student[1]);



ShoppingCart cart = new ShoppingCart();

cart[0] = "Laptop";
cart[1] = "Mouse";
cart[2] = "Keyboard";

Console.WriteLine(cart[0]);
Console.WriteLine(cart[1]);



Dictionary dictionary = new();

dictionary["name"] = "Asif";
dictionary["department"] = "CSE";

Console.WriteLine(dictionary["name"]);
Console.WriteLine(dictionary["department"]);


