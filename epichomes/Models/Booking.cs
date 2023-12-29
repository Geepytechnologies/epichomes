namespace epichomes.Models
{
    public class Booking
    {
        public Guid id { get; set; }

        public RoomType bookingfor { get; set; }

        public string price { get; set; }

        public Guid userid { get; set; }
    }
}
