using System;

public class Product
{
    private string name;
    private decimal price;
    private int quantity;

    public Product(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        this.quantity = quantity >= 0 ? quantity : 0;
    }

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Назва товару не може бути порожньою!");
            name = value;
        }
    }

    public decimal Price
    {
        get => price;
        set
        {
            if (value < 0)
                throw new ArgumentException("Ціна не може бути від'ємною!");
            price = value;
        }
    }

    public int Quantity => quantity;

    public decimal TotalValue => price * quantity;

    public void Restock(int amount)
    {
        if (amount <= 0)
            Console.WriteLine("Кількість для постачання повинна бути додатньою!");
        else
            quantity += amount;
    }

    public void Sell(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Кількість для продажу повинна бути додатньою!");
        }
        else if (amount > quantity)
        {
            Console.WriteLine("Недостатньо товару на складі!");
        }
        else
        {
            quantity -= amount;
        }
    }

    public string GetInfo()
    {
        return $"Товар: {name}, Ціна: {price} грн, Кількість: {quantity}, Загальна вартість: {TotalValue} грн";
    }
}