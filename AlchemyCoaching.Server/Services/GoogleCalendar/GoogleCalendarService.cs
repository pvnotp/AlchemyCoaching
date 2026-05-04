using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;

namespace AlchemyCoaching.Server.Services
{
    public class GoogleCalendarService : IGoogleCalendarService
    {
        private readonly CalendarService _calendarService;
        private readonly string _calendarId;

        public GoogleCalendarService(IConfiguration configuration)
        {
            var json = configuration["GoogleCalendar:ServiceAccountJson"]
                ?? throw new InvalidOperationException("GoogleCalendar:ServiceAccountJson is not configured.");

            _calendarId = configuration["GoogleCalendar:CalendarId"]
                ?? throw new InvalidOperationException("GoogleCalendar:CalendarId is not configured.");

            var credential = CredentialFactory
                .FromJson<ServiceAccountCredential>(json)
                .ToGoogleCredential()
                .CreateScoped(CalendarService.Scope.CalendarReadonly);

            _calendarService = new CalendarService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = "AlchemyCoaching"
            });
        }

        public async Task<IList<CalendarEventDto>> GetEventsAsync(DateTime? from, DateTime? to)
        {
            var fromUtc = (from ?? DateTime.UtcNow).ToUniversalTime();
            var toUtc = (to ?? fromUtc.AddDays(30)).ToUniversalTime();

            if (toUtc <= fromUtc)
            {
                throw new ArgumentException("The 'to' value must be greater than 'from'.");
            }

            var request = _calendarService.Events.List(_calendarId);
            request.TimeMinDateTimeOffset = fromUtc;
            request.TimeMaxDateTimeOffset = toUtc;
            request.SingleEvents = true;
            request.OrderBy = EventsResource.ListRequest.OrderByEnum.StartTime;

            var result = await request.ExecuteAsync();
            var items = result.Items ?? [];

            return items
                .Select(e => new CalendarEventDto
                {
                    Id = e.Id,
                    Summary = e.Summary,
                    Start = e.Start?.DateTimeDateTimeOffset ?? ToDateTimeOffset(e.Start?.Date),
                    End = e.End?.DateTimeDateTimeOffset ?? ToDateTimeOffset(e.End?.Date),
                    HtmlLink = e.HtmlLink,
                    Status = e.Status,
                    IsAllDay = !string.IsNullOrWhiteSpace(e.Start?.Date),
                })
                .ToList();
        }

        private static DateTimeOffset? ToDateTimeOffset(string? date)
        {
            if (string.IsNullOrWhiteSpace(date))
            {
                return null;
            }

            return DateTimeOffset.TryParse(date, out var parsed) ? parsed : null;
        }
    }
}
