namespace blazor.Models
{
    public class Card
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string? EventLocation { get; set; }
    }

}