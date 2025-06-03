namespace ClientPortal.Server.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public DateTime Time { get; set; }
        public Location Location { get; set; }
        public string? Note { get; set; }
    }
}
