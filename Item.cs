public class Item : ICollectable
{
    public string Name { get; set; }
    public string Description { get; set; }
    public ItemType Type { get; set; }

    public Item(string name, string description, ItemType type)
    {
        Name = name;
        Description = description;
        Type = type;
    }

    public enum ItemType
    {
        Weapon,
        Potion,
        Torch,
    }
    public class Weapon : Item
{
    public int Damage { get; }

    public Weapon(string name, int damage) : base(name, ItemType.Weapon)
    {
        Damage = damage;
    }

    public new void Use()
    {
        Console.WriteLine($"Swinging {Name}, dealing {Damage} damage.");
    }
}

public class Potion : Item
{
    public int HealAmount { get; }

    public Potion(string name, int healAmount) : base(name, ItemType.Potion)
    {
        HealAmount = healAmount;
    }

    public new void Use()
    {
        Console.WriteLine($"Drinking {Name}, healing for {HealAmount} health.");
    }
}

}
