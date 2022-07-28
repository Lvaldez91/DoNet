using ApiPlayer.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiPlayer.Data
{
    public class AplicationDbContext : DbContext
    {
        // constructor:
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> CategoryDB { get; set; }

    }
}
