namespace AlchemyCoaching.Server.Services
{
    public interface IGoogleCalendarService
    {
        Task<IList<CalendarEventDto>> GetEventsAsync(DateTime? from, DateTime? to);
    }

    public sealed class CalendarEventDto
    {
        public string? Id { get; init; }
        public string? Summary { get; init; }
        public DateTimeOffset? Start { get; init; }
        public DateTimeOffset? End { get; init; }
        public string? HtmlLink { get; init; }
        public string? Status { get; init; }
        public bool IsAllDay { get; init; }
    }
}
