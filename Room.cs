namespace DungeonExplorer
{
    public class Room
    {
        private string description;
        private string item;
        
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