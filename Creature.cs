public abstract class Creature : IDamageable
{
    public string Name { get; }

    protected Creature(string name)
    {
        Name = name;
    }

    public abstract void TakeDamage(int damage);
}