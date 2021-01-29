using System.Data.Entity;

namespace dbContext
{
    public class MyDatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }   
    }
}