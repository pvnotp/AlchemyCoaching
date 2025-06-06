using Bogus;
using ClientPortal.Server.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlchemyCoaching.Server.Data
{
    public class DemoDbContext(DbContextOptions options) : IdentityDbContext<PortalUser, IdentityRole, string>(options)
    {
        public DbSet<PortalUser> PortalUsers { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            var passwordHasher = new PasswordHasher<PortalUser>();
            var userFaker = new Faker<PortalUser>()
                .RuleFor(u => u.Id, f => Guid.NewGuid().ToString())
                .RuleFor(u => u.Name, f => f.Person.FirstName)
                .RuleFor(u => u.Email, (f, u)=> f.Internet.Email(u.Name, f.Person.LastName, "email.com"))
                .RuleFor(u => u.NormalizedEmail, (f, u) => u.Email?.ToLower())
                .RuleFor(u => u.UserName, (f, u) => u.NormalizedEmail)
                .RuleFor(u => u.NormalizedUserName, (f, u) => u.NormalizedEmail)
                .RuleFor(u => u.PasswordHash, (f, u) => passwordHasher.HashPassword(u, "password"))
                .RuleFor(u => u.TwoFactorEnabled, f => false);

            var fakeUsers = userFaker.GenerateBetween(10, 10);

            var alison = new PortalUser
            {
                Id = new Guid().ToString(),
                Name = "Alison",
                Email = "alisonjoyforster@gmail.com",
                NormalizedEmail = "alisonjoyforster@gmail.com",
                UserName = "alisonjoyforster@gmail.com",
                NormalizedUserName = "alisonjoyforster@gmail.com",
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
            builder.Entity<PortalUser>().HasData(fakeUsers);
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
