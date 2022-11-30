internal class Rooms
{
    private int maxRooms; // specifies the maximum number of rooms in the hotel
    private short roomNumber; // Specifies the room number 
    private int numberOfPersons; // Specifies the number of persons in the room
    private string registrantName; // name of the person who booked the room
    private Boolean isBooked; // 
    private List<Rooms> roomsList = new List<Rooms>(); // List of rooms

    public Rooms(short roomNumber, string registrantName, int numberOfPersons)
    {
        this.roomNumber = roomNumber;
        this.registrantName = registrantName;
        this.numberOfPersons = numberOfPersons;
        this.roomsList.Add(new Rooms (roomNumber, registrantName, numberOfPersons));
    }
    public void RemoveRoom(short roomNumber, string registrantName, int numberOfPersons)
    {
    }


    public void GetRoomInfoList()
    {
        foreach (var n in roomsList)
        {
            Console.WriteLine($"Room {n} information : ");
        }
    }

}