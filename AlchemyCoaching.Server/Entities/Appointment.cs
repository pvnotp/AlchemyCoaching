namespace AlchemyCoaching.Server.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public required string ClientId { get; set; }
        public required Coach Coach { get; set; }
        public required DateTime Time { get; set; }
        public required Location Location { get; set; }
        public string? Note { get; set; }
    }
}
