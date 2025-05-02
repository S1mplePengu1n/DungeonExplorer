public class Monster : Creature :IDamageable
{
    public int Health { get; private set; }
    public int AttackPower { get; set; }

    public Monster(string name, int health, attackpower) : base(name)
    {
        Health = health;
        AttackPower = attackpower;

    }

    public override void TakeDamage(int damage)
    {
        if (Health > 0)
        {
        Health -= damage;
        Console.WriteLine($"{Name} took {damage} damage, remaining health: {Health}");
        }
        else if (Health <= 0)
        {
        Health -= damage;
        Console.WriteLine($"{Monster} has been defeated")
        }
    }
    

    public void Attack(Player player)
    {
        int damage = 10; // Example damage
        player.TakeDamage(damage);
        Console.WriteLine($"{Name} attacked {player.Name} for {damage} damage!");
    }
}
