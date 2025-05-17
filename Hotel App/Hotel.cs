using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_App;

class Hotel
{
    public string Name { get; set; }
    private List<Room> rooms = new List<Room>(); 

    public Hotel(string name)
    {
        Name = name;
    }

    public void AddRoom(Room room)
    {
        rooms.Add(room);
    }

    public void MakeReservation(int roomId)
    {
        Room room = rooms.Find(r => r.Id == roomId);
        if (room != null)
        {
            if (room.IsAvailable)
            {
                room.IsAvailable = false;
                Console.WriteLine("Room reserved successfully.");
            }
            else
            {
                Console.WriteLine("Room is Full!");
            }
        }
        else
        {
            Console.WriteLine("Room not found!");
        }
    }
}





