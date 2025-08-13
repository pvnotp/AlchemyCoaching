using AlchemyCoaching.Server.Entities;
using Bogus;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlchemyCoaching.Server.Data
{
    public class AlchemyDbContext(DbContextOptions options) : IdentityDbContext<IdentityUser, IdentityRole, string>(options)
    {
        public DbSet<Appointment> Appointment { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            var passwordHasher = new PasswordHasher<IdentityUser>();
            var userFaker = new Faker<IdentityUser>()
                .RuleFor(u => u.Id, f => Guid.NewGuid().ToString())
                .RuleFor(u => u.Email, f => f.Internet.Email(f.Person.FirstName, f.Person.LastName, "email.com"))
                .RuleFor(u => u.NormalizedEmail, (f, u) => u.Email?.ToLower())
                .RuleFor(u => u.UserName, (f, u) => u.Email)
                .RuleFor(u => u.NormalizedUserName, (f, u) => u.Email?.ToLower())
                .RuleFor(u => u.PasswordHash, (f, u) => passwordHasher.HashPassword(u, "password"))
                .RuleFor(u => u.TwoFactorEnabled, f => false);

            var fakeUsers = userFaker.GenerateBetween(10, 10);

            var alison = new IdentityUser
            {
                Id = new Guid().ToString(),
                Email = "alisonjoyforster@gmail.com",
                NormalizedEmail = "alisonjoyforster@gmail.com",
                UserName = "Alison",
                NormalizedUserName = "alison",
                TwoFactorEnabled = false
            };

            alison.PasswordHash = passwordHasher.HashPassword(alison, "password");
            fakeUsers.Add(alison);

            var randomIndex = new Random();
            var appointmentFaker = new Faker<Appointment>()
                .RuleFor(u => u.Id, f => f.IndexFaker + 1)
                .RuleFor(a => a.ClientId, f => fakeUsers[randomIndex.Next(1,10)].Id)
                .RuleFor(a => a.Time, f => f.Date.Between(new DateTime(2025, 1, 1), new DateTime(2025, 12, 31)))
                .RuleFor(a => a.Location, f => Location.Online)
                .RuleFor(a => a.Note, f => f.Lorem.Text());

            var fakeAppointments = appointmentFaker.GenerateBetween(30, 30);


            base.OnModelCreating(builder);
            builder.HasDefaultSchema("AlchemyCoaching");
            builder.Entity<IdentityUser>().HasData(fakeUsers);
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
                        Name = "Coach",
                        NormalizedName = "COACH",
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
