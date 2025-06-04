using Bogus;
using ClientPortal.Server.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlchemyCoaching.Server.Data
{
    public class DemoDbContext(DbContextOptions options) : IdentityDbContext<User, IdentityRole, string>(options)
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            var passwordHasher = new PasswordHasher<User>();
            var userFaker = new Faker<User>()
                .RuleFor(u => u.Id, f => Guid.NewGuid().ToString())
                .RuleFor(u => u.FirstName, f => f.Person.FirstName)
                .RuleFor(u => u.LastName, f => f.Person.LastName)
                .RuleFor(u => u.Email, (f, u)=> f.Internet.Email(u.FirstName, u.LastName, "email.com"))
                .RuleFor(u => u.NormalizedEmail, (f, u) => u.Email?.ToLower())
                .RuleFor(u => u.UserName, (f, u) => u.NormalizedEmail)
                .RuleFor(u => u.NormalizedUserName, (f, u) => u.NormalizedEmail)
                .RuleFor(u => u.PasswordHash, (f, u) => passwordHasher.HashPassword(u, "password"))
                .RuleFor(u => u.TwoFactorEnabled, f => false);

            var fakeUsers = userFaker.GenerateBetween(10, 10);


            var randomIndex = new Random();
            var appointmentFaker = new Faker<Appointment>()
                .RuleFor(u => u.Id, f => f.IndexFaker + 1)
                .RuleFor(a => a.ClientId, f => fakeUsers[randomIndex.Next(1,10)].Id)
                .RuleFor(a => a.Time, f => f.Date.Between(new DateTime(2025, 1, 1), new DateTime(2025, 7, 1)))
                .RuleFor(a => a.Location, f => Location.Online)
                .RuleFor(a => a.Note, f => f.Lorem.Text());

            var fakeAppointments = appointmentFaker.GenerateBetween(30, 30);


            base.OnModelCreating(builder);
            builder.HasDefaultSchema("AlchemyCoaching");
            builder.Entity<User>().HasData(fakeUsers);
            builder.Entity<Appointment>().HasData(fakeAppointments);
            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Client",
                        NormalizedName = "CLIENT",
                    },
                    new IdentityRole
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Admin",
                        NormalizedName = "ADMIN",
                    }
                );

        }
    }
}
