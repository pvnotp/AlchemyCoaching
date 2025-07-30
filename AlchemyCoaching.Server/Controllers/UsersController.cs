
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AlchemyCoaching.Server.Data;
using Microsoft.AspNetCore.Identity;
using ClientPortal.Server.Entities;

namespace AlchemyCoaching.Server.Controllers
{
    [Route("users")]
    [ApiController]
    public class UsersController(AlchemyDbContext context, ILogger<UsersController> logger) : ControllerBase
    {

        // GET: api/clients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<IdentityUser>>> GetUsers()
        {
            logger.LogInformation("HELLO");
            return await context.Users.ToListAsync();
        }

        // GET: api/users/email@email.com
        [HttpGet("{email}")]
        public async Task<ActionResult<IdentityUser>> GetUser(string email)
        {
            var user = await context.Users.FirstAsync(user => user.Email == email);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

        // PUT: api/users/
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUser(string id, IdentityUser user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            context.Entry(user).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<IdentityUser>> PostUser(IdentityUser user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        // DELETE: api/users/2b1ded3c-f415-4717-87ac-cf68219eb2f9
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            context.Users.Remove(user);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool UserExists(string id)
        {
            return context.Users.Any(e => e.Id == id);
        }
    }
}