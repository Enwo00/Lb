public class Enemy : IDamageable
{
    public int Health { get; private set; }

    public Enemy(int health)
    {
        Health = health;
    }

    public void TakeDamage(int amount)
    {
        Health -= amount;
        Console.WriteLine($"Ворог отримав {amount} шкоди. Залишилось здоров'я: {Health}");

        if (Health <= 0)
        {
            Console.WriteLine("Ворог знищений!");
        }
    }
}