using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_App;

class Room
{

    private static int nextId = 1; 
    public int Id { get; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int PersonCapacity { get; set; }
    public bool IsAvailable { get; set; } = true; 

    public Room(string name, decimal price, int personCapacity)
    {
        Id = nextId++;
        Name = name;
        Price = price;
        PersonCapacity = personCapacity;
    }

    public string ShowInfo()
    {
        return $"Room ID: {Id}, Name: {Name}, Price: {Price}, Capacity: {PersonCapacity}, Available: {IsAvailable}";
    }

    public override string ToString()
    {
        return ShowInfo();
    }
}



