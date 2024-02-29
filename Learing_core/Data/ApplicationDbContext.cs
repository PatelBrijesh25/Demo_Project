using Microsoft.EntityFrameworkCore;
namespace Learing_core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        
        }
       public DbSet<Learing_core.Models.Task> Tasks { get; set; }
    }
}
