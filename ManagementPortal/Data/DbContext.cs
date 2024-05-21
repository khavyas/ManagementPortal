using System.Collections.Generic;
using System.Data.Entity;
using System.Reflection.Emit;

namespace ManagementPortal.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserProfile> UserProfiles { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Define relationships and constraints
        }
    }

}
