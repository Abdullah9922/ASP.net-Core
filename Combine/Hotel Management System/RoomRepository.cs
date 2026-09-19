using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Management_System
{
    public class RoomRepository
    {
        private readonly List<Room> _rooms = new();

        public void AddRoom(Room room)
        {
            bool found = _rooms.Any(x => x.RoomNumber == room.RoomNumber);
            if (_rooms != null && !found)
            {
                _rooms.Add(room);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid! Try Again");
                Console.WriteLine();
            }
        }

        public void RemoveRoom(int id)
        {
            Room? room = _rooms.FirstOrDefault(x => x.RoomNumber == id);
            if (room != null)
            {
                _rooms.Remove(room);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Customer not Found.");
                Console.WriteLine();
            }
        }

        public Room? GetById(int id)
        {
            Room? room = _rooms.FirstOrDefault(x => x.RoomNumber == id);
            if (room != null) return room;
            else return null;
        }

        public void ShowRoomDetails(int id)
        {
            Room? c = _rooms.FirstOrDefault(x => x.RoomNumber == id);
            if (c != null)
            {
                Room.PrintInfo(c);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Room not Found.");
                Console.WriteLine();
            }
        }

        public void ShowAvailableRoom()
        {
            if(_rooms != null)
            {
                foreach (Room room in _rooms)
                {
                    if(room.Availability == true)
                    {
                        Room.PrintInfo(room);
                    }
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Room not Found.");
                Console.WriteLine();
            }
        }
    }
}
