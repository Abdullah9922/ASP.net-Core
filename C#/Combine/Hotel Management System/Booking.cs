using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Management_System
{
    public class Booking
    {
        public int BookingId { get; private set; }
        public Customer? Customer { get; private set; }
        public Room? Room { get; private set; }
        public DateTime CheckInDate { get; private set; }
        public DateTime CheckOutDate { get; private set; }
        public int NumberOfNights { get; private set; }
        public double TotalCost { get; private set; }
        public BookingStatus Status { get; private set; }


        public Booking(int bookingId,Customer customer,Room room,DateTime checkInDate,DateTime checkOutDate)
        {
            BookingId = bookingId;
            Customer = customer;
            Room = room;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            NumberOfNights = (checkOutDate - checkInDate).Days;
            TotalCost = NumberOfNights * room.Price;
            Status = BookingStatus.Pending;
        }

        public static void ChangeStatus(Booking booking,BookingStatus status)
        {
            booking.Status = status;
        }

        public static void PrintInfo(Booking b)
        {
            Console.WriteLine();
            Console.WriteLine($"Booking ID      : {b.BookingId}");
            Console.WriteLine($"Customer ID     : {b.Customer.Id}");
            Console.WriteLine($"Customer Name   : {b.Customer.Name}");
            Console.WriteLine($"Room Number     : {b.Room?.RoomNumber}");
            Console.WriteLine($"Room Type       : {b.Room?.Type}");
            Console.WriteLine($"Check-In Date   : {b.CheckInDate:dd-MM-yyyy HH:mm}");
            Console.WriteLine($"Check-Out Date  : {b.CheckOutDate:dd-MM-yyyy HH:mm}");
            Console.WriteLine($"Number of Nights: {b.NumberOfNights}");
            Console.WriteLine($"Total Cost      : {b.TotalCost:F2}");
            Console.WriteLine($"Status          : {b.Status}");
            Console.WriteLine();
        }
    }
}
