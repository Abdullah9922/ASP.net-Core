using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Management_System
{
    public class Room
    {
        public int RoomNumber { get; private set; }
        public double Price { get; private set; }
        public RoomType Type { get; private set; }
        public bool Availability { get; private set; }

        public Room(int  roomNumber, RoomType type)
        {
            RoomNumber = roomNumber;
            Availability = true;
            Type = type;
            if (type == RoomType.Single) Price = 1000.00;
            else if (type == RoomType.Double) Price = 2000.00;
            else if (type == RoomType.Deluxe) Price = 4000.00;
        }

        public static void ChangeRoomAvailabilty(Room r)
        {
            r.Availability = false;
        }
        public static void ChangeRoomAvailabilty2(Room r)
        {
            r.Availability = true;
        }


        public static void PrintInfo(Room r)
        {
            Console.WriteLine();
            Console.WriteLine($"Room Number : {r.RoomNumber}");
            Console.WriteLine($"Type        : {r.Type}");
            Console.WriteLine($"Price       : {r.Price}");
            Console.WriteLine($"Availability: {r.Availability}");
            Console.WriteLine();
        }
    }
}
