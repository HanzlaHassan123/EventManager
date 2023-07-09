using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EventManager.Models.Domain
{
    public class DatabaseContext: IdentityDbContext<ApplicationUser>
    {
      public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        {
        
        }

        public DbSet<Event> Events { get; set; }
        public DbSet<EventCategory> EventCategory { get; set; }
        public DbSet<Category> Category { get; set; }


    }
}
