public class Program
{
    public static void Main()
    {
       
        Admin admin = new Admin("AdminUser", "admin@example.com");
        admin.SetPassword("admin123");

        Moderator mod = new Moderator("ModUser", "mod@example.com");
        mod.SetPassword("mod123");

        RegularUser user = new RegularUser("RegUser", "user@example.com");
        user.SetPassword("user123");

      
        List<User> users = new List<User> { admin, mod, user };

        Console.WriteLine("=== Інформація про користувачів ===");
        foreach (User u in users)
        {
            u.DisplayInfo();
        }

        Console.WriteLine("\n=== Тестування методів ===");

        foreach (User u in users)
        {
            if (u is Admin a)
            {
                a.BlockUser(user);
            }
            else if (u is Moderator m)
            {
                m.ModerateContent();
            }
            else if (u is RegularUser r)
            {
                r.PostComment();
            }
        }

        Console.WriteLine("\n=== Перевірка аутентифікації ===");

       
        Console.WriteLine($"{admin.UserName}: " +
            (admin.Authenticate("admin123") ? "Успішна аутентифікація" : "Невірний пароль"));

        Console.WriteLine($"{mod.UserName}: " +
            (mod.Authenticate("wrongpass") ? "Успішна аутентифікація" : "Невірний пароль"));

        Console.WriteLine($"{user.UserName}: " +
            (user.Authenticate("user123") ? "Успішна аутентифікація" : "Невірний пароль"));
    }
}