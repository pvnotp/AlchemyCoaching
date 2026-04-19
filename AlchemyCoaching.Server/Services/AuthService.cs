using AlchemyCoaching.Server.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AlchemyCoaching.Server.Services
{
    public class AuthService(AlchemyDbContext context) : IAuthService
    {
        public async Task<List<IdentityUser>> GetUsersAsync()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<IdentityUser?> GetUserByEmailAsync(string email)
        {
            return await context.Users.FirstOrDefaultAsync(user => user.Email == email);
        }

        public async Task<bool> UserExistsAsync(string id)
        {
            return await context.Users.AnyAsync(user => user.Id == id);
        }

        public async Task<string> GetSingleRoleNameAsync(string id)
        {
            return await (
                from userRole in context.UserRoles
                join role in context.Roles on userRole.RoleId equals role.Id
                where userRole.UserId == id
                select role.Name).SingleAsync();
        }
    }
}
