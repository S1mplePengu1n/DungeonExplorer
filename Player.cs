using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DungeonExplorer
{
    public class Player : Creature :IDamageable
    {
        private string _name;
        private string _description;
        private int _inventory;
        private int _health;
        public string Name
        public Room CurrentRoom { get; set; }

        {
            get { return _name; }
            set
            {
                _name = string.IsNullOrEmpty(value) ? "NoName" : value;
            }
        }
public int Health
        {
            _health = 100;
            get { return _health; }
            set
            {
                _health = (value >= 0 && value <= 100) ? value : 0;
            }
        }
        public int Inventory
        {
            get { return _inventory; }
            set
            {
                _inventory = (value >= 0 && value <= 1) ? value : 0;
            }
        }

        public Player(string _name, int _health, int _inventory) 
        {
            Name = _name;
            Health = _health;
            Inventory = _inventory;
        }
        
        public void PickUpItem(string item)
        {
           if (Inventory =! null)
            {
                inventory.AddItem(item);
                Console.WriteLine($"You picked up: {item}");
                item = null;
            }
            else
            {
                Console.WriteLine("Inventory is full! Can't carry anymore items.");
            }
        }
       
    

        public string InventoryContents()
        {
            return string.Join(", ", Inventory);
        }
        public void DisplayStatus()
        {
            Console.WriteLine($"Player: {Name} | Health: {health} | Inventory: {inventory ?? "None"}");
            
        }
        public void MoveToRoom(Room room)
    {
        CurrentRoom = room;
        Console.WriteLine($"\n{this.Name} moved to {room.Name}.");
    }
      public void TakeDamage(int damage)
    {
        Health -= damage;
        if (Health < 0) Health = 0;
        Console.WriteLine($"{Name} takes {damage} damage. Health is now {Health}.");
    }

    public void Heal(int amount)
    {
        Health += amount;
        Console.WriteLine($"{Name} heals for {amount}. Health is now {Health}.");
    }
     public void Attack(Monster monster)
    {
        Console.WriteLine($"{Name} attacks {monster.Name} for {AttackPower} damage.");
        monster.TakeDamage(AttackPower);
    }

    public void MoveToRoom(Room room)
    {
        CurrentRoom = room;
        Console.WriteLine($"\n{Name} moved to {room.Name}.");
    }
    }
    
}