using CafeApplication.Database.Framework.Models.User;
using Microsoft.EntityFrameworkCore;

namespace CafeApplication.Database.Framework
{
    public class DatabaseContext : DbContext
    {
        public DbSet<UserDto> Users { get; set; }
        public DatabaseContext(DbContextOptions options)
          : base(options)
        {
        }
    }
}
