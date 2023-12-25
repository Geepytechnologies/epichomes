using System.ComponentModel.DataAnnotations.Schema;

namespace epichomes.Models
{
    public class Image
    {
        public Guid ImageId { get; set; }
        public string? ImageUrl { get; set; }

        [ForeignKey("Room")]
        public Guid RoomId { get; set; }

        [InverseProperty("Images")]
        public Room? Room { get; set; }
    }
}
