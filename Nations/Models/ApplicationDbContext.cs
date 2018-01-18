using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Nations.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Nation> Nations { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<GovernmentType> GovernmentTypes { get; set; }
        public DbSet<GeographyType> GeographyTypes { get; set; }
        public DbSet<EconomyType> EconomyTypes { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(entity => {
                entity.Property(m => m.Email).HasMaxLength(127);
                entity.Property(m => m.NormalizedEmail).HasMaxLength(127);
                entity.Property(m => m.UserName).HasMaxLength(127);
                entity.Property(m => m.NormalizedUserName).HasMaxLength(127);
            });

            builder.Entity<IdentityRole>(entity => {
                entity.Property(m => m.Name).HasMaxLength(127);
                entity.Property(m => m.NormalizedName).HasMaxLength(127);
            });
        }
    }
}
