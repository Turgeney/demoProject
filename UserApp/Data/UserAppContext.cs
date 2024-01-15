using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UserApp.Models;

namespace UserApp.Data
{
    public class UserAppContext : DbContext
    {
        public UserAppContext (DbContextOptions<UserAppContext> options)
            : base(options)
        {
        }

        public DbSet<UserApp.Models.User> User { get; set; } = default!;
    }
}
