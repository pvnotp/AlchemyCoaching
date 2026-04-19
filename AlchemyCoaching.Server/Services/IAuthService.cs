using Microsoft.AspNetCore.Identity;

namespace AlchemyCoaching.Server.Services
{
    public interface IAuthService
    {
        Task<List<IdentityUser>> GetUsersAsync();
        Task<IdentityUser?> GetUserByEmailAsync(string email);
        Task<bool> UserExistsAsync(string id);
        Task<string> GetSingleRoleNameAsync(string id);
    }
}
