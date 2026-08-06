using Vehicle_Rental_Management_System;

Console.WriteLine("Hello, World!");


Car car = new Toyota("Toyota", "m38762", 2008, 250000, true, 5, "Engine is hybird");


//car.Honk();

//car.DisplayEngine();

//car.ShowDetails();




Vehicle v = new Toyota("Toyota", "m38762", 2008, 250000, true, 5, "Engine is hybird");
v.DisplayEngine();

v.Honk();

v.ShowDetails();