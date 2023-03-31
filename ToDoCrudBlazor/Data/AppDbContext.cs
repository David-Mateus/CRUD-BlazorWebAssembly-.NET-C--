using Microsoft.EntityFrameworkCore;
using ToDoCrudBlazor.Models;


namespace ToDoCrudBlazor.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Company>Companies { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { 

        }
    }
}
