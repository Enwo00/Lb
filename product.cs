using System;
using System.Collections.Generic;

public class User
{
    public string UserName { get; set; }
    public string Email { get; set; }
    private string _password;

    public User(string userName, string email)
    {
        UserName = userName;
        Email = email;
    }

    public void SetPassword(string newPassword)
    {
        _password = newPassword;
    }

    public bool Authenticate(string inputPassword)
    {
        return _password == inputPassword;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Ім'я: {UserName} | Email: {Email}");
    }
}

public class Admin : User
{
    public Admin(string userName, string email) : base(userName, email) { }

    public void BlockUser(User user)
    {
        Console.WriteLine($"Користувача {user.UserName} заблоковано.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Роль: Адміністратор");
    }
}

public class Moderator : User
{
    public Moderator(string userName, string email) : base(userName, email) { }

    public void ModerateContent()
    {
        Console.WriteLine("Контент модеровано.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Роль: Модератор");
    }
}

public class RegularUser : User
{
    public RegularUser(string userName, string email) : base(userName, email) { }

    public void PostComment()
    {
        Console.WriteLine("Коментар опубліковано.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Роль: Звичайний користувач");
    }
}