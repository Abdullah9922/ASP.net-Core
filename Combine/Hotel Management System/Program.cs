using Hotel_Management_System;

BookingRepository bookingRepo = new BookingRepository();
CustomerRepository customerRepo = new CustomerRepository();
RoomRepository roomRepo = new RoomRepository();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("=================================");
    Console.WriteLine("      HOTEL MANAGEMENT SYSTEM");
    Console.WriteLine("=================================");

    Console.WriteLine("1. Add Room");
    Console.WriteLine("2. Add Customer");
    Console.WriteLine("3. Show Available Rooms");
    Console.WriteLine("4. Create Booking");
    Console.WriteLine("5. Cancel Booking");
    Console.WriteLine("6. Make Payment");
    Console.WriteLine("7. Show Booking Details");
    Console.WriteLine("8. Show Customer Details");
    Console.WriteLine("0. Exit");

    Console.WriteLine("=================================");
    Console.Write("Enter your choice: ");

    int choice = int.Parse(Console.ReadLine()!);

    switch (choice)
    {
        case 1:
            Console.Write("Enter Room Number: ");
            int roomNumber = int.Parse(Console.ReadLine()!);

            Console.Write("Enter Room Type (Single/Double/Deluxe): ");
            RoomType type = Enum.Parse<RoomType>(Console.ReadLine()!, true);
            Room r = new Room(roomNumber, type);
            roomRepo.AddRoom(r);
            break;

        case 2:
            Console.Write("Enter Customer ID: ");
            int id = int.Parse(Console.ReadLine()!);

            Console.Write("Enter Customer Name: ");
            string name = Console.ReadLine()!;

            Console.Write("Enter Phone Number: ");
            long phoneNumber = long.Parse(Console.ReadLine()!);

            Console.Write("Enter Email: ");
            string? email = Console.ReadLine();

            Console.Write("Enter Customer Type (Regular/VIP): ");
            CustomerType type2 = Enum.Parse<CustomerType>(Console.ReadLine()!, true);

            Customer customer = new Customer(id, name, phoneNumber, email, type2);

            customerRepo.AddCustomer(customer);
            break;

        case 3:
            roomRepo.ShowAvailableRoom();
            break;

        case 4:
            Console.Write("Enter Booking ID: ");
            int bookingId = int.Parse(Console.ReadLine()!);

            Console.Write("Enter Customer ID: ");
            int customerId = int.Parse(Console.ReadLine()!);

            Customer? cr = customerRepo.GetById(customerId);

            if (cr == null)
            {
                Console.WriteLine("Customer not found!");
                continue;
            }

            Console.Write("Enter Room Number: ");
            int roomId = int.Parse(Console.ReadLine()!);

            Room? room = roomRepo.GetById(roomId);

            if (room == null)
            {
                Console.WriteLine("Room not found!");
                continue;
            }

            Console.Write("Enter Check-In Date (dd-MM-yyyy HH:mm): ");
            DateTime checkInDate = DateTime.ParseExact(Console.ReadLine()!,"dd-MM-yyyy HH:mm",null);

            Console.Write("Enter Check-Out Date (dd-MM-yyyy HH:mm): ");
            DateTime checkOutDate = DateTime.ParseExact(Console.ReadLine()!,"dd-MM-yyyy HH:mm",null);

            Booking booking = new Booking(bookingId,cr,room,checkInDate,checkOutDate);

            bookingRepo.CreateBooking(booking);
            break;

        case 5:
            Console.WriteLine("Enter Booking Id: ");
            int cancelId = int.Parse(Console.ReadLine()!);
            bookingRepo.CancelBooking(cancelId);
            break;

        case 6:
            Console.WriteLine("Enter Booking Id: ");
            int paymentId = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter Amount: ");
            int amount = int.Parse(Console.ReadLine()!);
            bookingRepo.MakePayment(paymentId,amount);
            break;

        case 7:
            Console.WriteLine("Enter Booking Id: ");
            int showId = int.Parse(Console.ReadLine()!);
            bookingRepo.ShowBooking(showId);
            break;

        case 8:
            Console.WriteLine("Enter Customer Id: ");
            int cusId = int.Parse(Console.ReadLine()!);
            customerRepo.ShowCustomerDetails(cusId);
            break;

        case 0:
            Console.WriteLine("Thank you for using Hotel Management System!");
            return;

        default:
            Console.WriteLine("Invalid choice!");
            break;
    }

    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
    Console.Clear();
}
