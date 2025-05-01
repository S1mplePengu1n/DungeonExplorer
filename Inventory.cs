using System;
using System.Collections.Generic;
using System.Linq;

public class Inventory
{
    public List<Item> Items { get; }

    public Inventory()
    {
        Items = new List<Item>();
    }

    public void AddItem(Item item)
    {
        Items.Add(item);
    }

    public void ShowItems()
    {
        if (!Items.Any())
        {
            Console.WriteLine("No items in inventory.");
            return;
        }

        foreach (var item in Items)
        {
            Console.WriteLine($"- {item.Name} ({item.Type})");
        }
    }

    //  Show weapons
    public void ShowWeapons()
    {
        var weapons = Items.Where(i => i.Type == ItemType.Weapon);
        Console.WriteLine("Weapons in inventory:");
        foreach (var weapon in weapons)
        {
            Console.WriteLine($"- {weapon.Name}");
        }
    }

    //  Show potions
    public void ShowPotions()
    {
        var potions = Items.Where(i => i.Type == ItemType.Potion);
        Console.WriteLine("Potions in inventory:");
        foreach (var potion in potions)
        {
            Console.WriteLine($"- {potion.Name}");
        }
    }

    // Sort items by name
    public void ShowSortedItems()
    {
        var sorted = Items.OrderBy(i => i.Name);
        Console.WriteLine("Inventory sorted by name:");
        foreach (var item in sorted)
        {
            Console.WriteLine($"- {item.Name} ({item.Type})");
        }
    }
      public Item GetItem(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            Item item = items[index];
            items.RemoveAt(index); // remove on use
            return item;
        }
        return null;
    }
}

