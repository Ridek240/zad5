using Microsoft.EntityFrameworkCore;
namespace zad5.Model
{
    public class DbProductContext : DbContext
    {
        public DbProductContext( DbContextOptions options) : base(options) { }
        public DbSet<DbProducts> DbProduct { get; set; }
    }
}
