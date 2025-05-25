using System.ComponentModel.DataAnnotations;

namespace blazor.Models
{
    public class Card
    {
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        [Url]
        public string? ImageUrl { get; set; }
        [Required]
        public string? EventName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yy}", ApplyFormatInEditMode = true)]
        public DateTime? EventDate { get; set; }
        [Required]
        public string? EventLocation { get; set; }
    }

}