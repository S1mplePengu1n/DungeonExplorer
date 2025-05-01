namespace DungeonExplorer
{
    public class Room
    {
        private string description;
        private string item;
         public Monster Monster { get; set; }
        public Item Item { get; set; }
        public List<Room> ConnectedRooms { get; set; }
        
        
        public void pickItem(string item)
        {
          items.Add(item);
        Console.WriteLine($"{item} has been added to your inventory.");
           
        }
    


        public Room(string description)
        {
            this.description = description;
            this.item = item
        }

        public string GetDescription()
        {
            return description;
        }
    }
}
public class Room
{
    public string Description { get; }
    public Item Item { get; set; }
    public List<Monster> Monsters { get; set; }

    public Room(string description, Item item)
    {
        Description = description;
        Item = item;
        Monsters = new List<Monster>(); // Initialize empty monster list
    }

    public string GetDescription() => Description;

     public void ConnectRoom(Room room)
    {
        if (!ConnectedRooms.Contains(room))
        {
            ConnectedRooms.Add(room);
            room.ConnectedRooms.Add(this); // bidirectional connection
        }
    }
}

