using Microsoft.EntityFrameworkCore;
using UserApp.Data;

namespace UserApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider) {
            using (var context = new UserAppContext(serviceProvider.GetRequiredService<DbContextOptions<UserAppContext>>()))
            {
                if (context == null || context.User == null)

                {
                    throw new ArgumentNullException("Null UserAppContext!");
                }
                if (context.User.Any())
                {
                    return;   // Уже внесены
                }

                context.User.AddRange(
                    new User
                    {
                        Name = "Иван Иванов",
                        DoB = DateTime.Parse("1989-2-12"),
                        Email = "ivan@example.com",
                        Position = "инженер-технолог"
                    },
                    new User
                    {
                        Name = "Алексей Каменев",
                        DoB = DateTime.Parse("1988-1-5"),
                        Email = "pavel@example.com",
                        Position = "инженер-технолог"
                    },
                    new User
                    {
                        Name = "Павел Павлов",
                        DoB = DateTime.Parse("1989-3-13"),
                        Email = "cond@example.com",
                        Position = "оператор"
                    },
                    new User
                    {
                        Name = "Михаил Беляков",
                        DoB = DateTime.Parse("1990-4-15"),
                        Email = "tren@example.com",
                        Position = "оператор"
                    },
                    new User
                    {
                        Name = "Иван Стасов",
                        DoB = DateTime.Parse("1991-12-12"),
                        Email = "stas@example.com",
                        Position = "оператор"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
