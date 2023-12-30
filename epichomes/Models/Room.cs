namespace epichomes.Models
{
    public enum RoomType
    {
        Hotels,
        Apartments,
        Resorts,
        Villas
    }
    public class Room
    {
        public Guid Id { get; set; }
        public string? RoomName { get; set; }

        public string? RoomDescription { get; set; }

        public ICollection<Image> Images { get; set; } = new List<Image>();

        public string? Price { get; set; }

        public string? Location { get; set; }


        public RoomType? RoomType { get; set;}

        public bool RoomBooked { get; set; }

        public User? RoomOccupant { get; set; }
    
    }
}
