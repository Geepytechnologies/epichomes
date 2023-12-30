using Microsoft.AspNetCore.Identity;

namespace epichomes.Models
{
    public class Booking
    {
        public Guid id { get; set; }

        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        // Other booking properties

        // Foreign key for the relationship with Room
        public int RoomId { get; set; }

        // Navigation property for the relationship
        public Room Room { get; set; }

        // Foreign key for the relationship with IdentityUser
        public string UserId { get; set; }
        //public ApplicationUser User { get; set; }
    }
}
