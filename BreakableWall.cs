public class BreakableWall : IDamageable
{
    public int Durability { get; private set; }

    public BreakableWall(int durability)
    {
        Durability = durability;
    }

    public void TakeDamage(int amount)
    {
        Durability -= amount;
        Console.WriteLine($"Стіна отримала {amount} шкоди. Міцність залишилась: {Durability}");

        if (Durability <= 0)
        {
            Console.WriteLine("Стіна зруйнована!");
        }
    }
}