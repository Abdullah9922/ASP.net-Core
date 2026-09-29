using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Management_System
{
    public class BookingRepository
    {
        private readonly List<Booking> _bookings = new();

        public void CreateBooking(Booking booking)
        {
            bool found = _bookings.Any(x => x.BookingId == booking.BookingId);
            if (_bookings != null && !found)
            {
                _bookings.Add(booking);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid! Try Again");
                Console.WriteLine();
            }
        }

        public void CancelBooking(int id)
        {
            Booking? booking = _bookings.FirstOrDefault(x => x.BookingId == id);
            if (booking != null)
            {
                _bookings.Remove(booking);
                Room.ChangeRoomAvailabilty2(booking.Room);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Customer not Found.");
                Console.WriteLine();
            }
        }

        public void MakePayment(int id, double amount)
        {
            Booking? b = _bookings.FirstOrDefault(x => x.BookingId == id);
            RoomRepository rr = new RoomRepository();
            if (b != null)
            {
                if(amount  == b.TotalCost)
                {
                    Booking.ChangeStatus(b, BookingStatus.Approved);
                    Room? r = rr.GetById(b.Room.RoomNumber);
                    if (r != null)
                    {
                        Room.ChangeRoomAvailabilty(r);

                    }
                    else Console.WriteLine("Room not found");
                }
                else Booking.ChangeStatus(b,BookingStatus.Rejected);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Booking not Found.");
                Console.WriteLine();
            }
        }

        public void ShowBooking(int id)
        {
            Booking? b = _bookings.FirstOrDefault(x => x.BookingId == id);
            if (b != null)
            {
                Booking.PrintInfo(b);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Booking not Found.");
                Console.WriteLine();
            }
        }
    }
}
