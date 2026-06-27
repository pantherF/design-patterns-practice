class House
{
    private List<Room> Rooms { get; set; } = [];

    public void AddRoom(string name, double sqMeters)
    {
        Rooms.Add(new Room(name, sqMeters));
    }

    public double GetTotalArea()
    {
        var totalSqMeters = 0.0;

        foreach (var room in Rooms)
        {
            totalSqMeters += room.SqMeters;
        }

        return Math.Round(totalSqMeters, 2);
    }

    public void ShowRooms()
    {
        foreach (var room in Rooms)
        {
            Console.WriteLine("+");
            Console.WriteLine(room.Name);
            Console.WriteLine(room.SqMeters);
        }
    }

    private class Room(string name, double sqMeters)
    {
        public string Name { get; set; } = name;
        public double SqMeters { get; set; } = sqMeters;
    }
}