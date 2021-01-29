using System.Data.Entity;

namespace WebApplication.Models
{
    public class EFContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}