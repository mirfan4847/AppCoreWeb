using Microsoft.EntityFrameworkCore;

namespace AppCoreWeb.Model
{
    public class UsersDbContext : DbContext
    {
        public UsersDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<tblUsers> Users { get; set; }

    }
}
