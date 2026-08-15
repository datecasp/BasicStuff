using BasicStuff.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace BasicStuff.Infra.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Users { get; set; }
    }
}
