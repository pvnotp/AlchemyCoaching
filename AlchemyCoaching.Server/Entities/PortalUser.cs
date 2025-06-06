using AlchemyCoaching.Server.Entities;
using Microsoft.AspNetCore.Identity;

namespace ClientPortal.Server.Entities
{
    public class PortalUser : IdentityUser
    {
        public string? Name { get; set; }
        public Role Role { get; set; }
    }
}
