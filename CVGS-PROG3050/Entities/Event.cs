namespace CVGS_PROG3050.Entities
{
    public class Event
    {
        public int EventId { get; set; }
        public string? EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string? Location { get; set; }
        public string? LocationType { get; set; }
        public string? Description { get; set; }
        public decimal? EventPrice { get; set; }
        public ICollection<UserEvent>? UserEvents { get; set; }
    }
}
