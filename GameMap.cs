using System;
using System.Collections.Generic;

public class GameMap
{
    private Dictionary<string, Room> rooms;

    public GameMap()
    {
        rooms = new Dictionary<string, Room>();
    }

    public void AddRoom(string key, Room room)
    {
        rooms[key] = room;
    }

    public Room GetRoom(string key)
    {
        if (rooms.ContainsKey(key))
        {
            return rooms[key];
        }
        else
        {
            Console.WriteLine("Room does not exist.");
            return null;
        }
    }
}
