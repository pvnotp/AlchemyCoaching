using AlchemyCoaching.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlchemyCoaching.Server.Controllers
{
    [Route("calendar")]
    [ApiController]
    public class GoogleCalendarController(IGoogleCalendarService googleCalendarService) : ControllerBase
    {
        [HttpGet("events")]
        public async Task<ActionResult<IList<GoogleCalendarEventDto>>> GetEvents([FromQuery] DateTime? from, [FromQuery] DateTime? to)
        {
            try
            {
                var events = await googleCalendarService.GetEventsAsync(from, to);
                return Ok(events);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
