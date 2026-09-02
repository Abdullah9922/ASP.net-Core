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


// 
IStudent student = new Student();

// -------------------------
// 1. ONLY GET
// -------------------------

Console.WriteLine(student.Name);   // ✅ get

// student.Name = "Rahim";         // ❌ Error
// কারণ interface-এ শুধু get আছে


// -------------------------
// 2. ONLY SET
// -------------------------

student.Age = 22;                  // ✅ set

// Console.WriteLine(student.Age); // ❌ Error
// কারণ interface-এ শুধু set আছে


// -------------------------
// 3. GET + SET
// -------------------------

student.Department = "CSE";       // ✅ set

Console.WriteLine(student.Department); // ✅ get