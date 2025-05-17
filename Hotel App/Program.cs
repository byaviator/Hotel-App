 namespace Hotel_App;

internal class Program
{
    static void Main(string[] args)
    {
        Hotel hotel = null;
        Room newRoom = null; 

        while (true)
        {
            Console.WriteLine("1. Create a room");
            Console.WriteLine("2. Add room");
            Console.WriteLine("3. Make reserve");
            Console.WriteLine(". Exit");
            Console.Write("Please select an option: ");
            string choice = Console.ReadLine().Trim();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter room name: ");
                    string roomName = Console.ReadLine();
                    Console.Write("Enter room price: ");
                    decimal roomPrice = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter person capacity: ");
                    int roomCapacity = int.Parse(Console.ReadLine());
                    newRoom = new Room(roomName, roomPrice, roomCapacity);
                    Console.WriteLine("Room created successfully.");
                    break;

                case "2":
                    if (hotel == null)
                    {
                        Console.Write("Enter hotel name: ");
                        string hotelName = Console.ReadLine();
                        hotel = new Hotel(hotelName);
                        Console.WriteLine("Hotel created successfully.");
                    }
                    if (newRoom != null) 
                    {
                        hotel.AddRoom(newRoom);
                        Console.WriteLine("Room added to hotel.");
                    }
                    else
                    {
                        Console.WriteLine("No room created to add!");
                    }
                    break;

                case "3":
                    Console.Write("Enter room ID for reservation: ");
                    int roomId = int.Parse(Console.ReadLine());
                    hotel.MakeReservation(roomId);
                    break;

                case "":
                    Console.WriteLine("Exiting the application.");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}

