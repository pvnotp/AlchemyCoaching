using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AlchemyCoaching.Server.Entities;

namespace AlchemyCoaching.Server.Data
{
    public class AlchemyDbContext(DbContextOptions options) : IdentityDbContext<IdentityUser, IdentityRole, string>(options)
    {
        public DbSet<Appointment> Appointment { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("AlchemyCoaching");

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "r1000000-0000-0000-0000-000000000001",
                    Name = "Client",
                    NormalizedName = "CLIENT",
                },
                new IdentityRole
                {
                    Id = "r1000000-0000-0000-0000-000000000002",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                }
            );
        }
    }
}
