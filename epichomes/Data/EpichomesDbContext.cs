using epichomes.Models;
using Microsoft.EntityFrameworkCore;

namespace epichomes.Data
{
    public class EpichomesDbContext : DbContext
    {
        public EpichomesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Image> Images { get; set; }

    }
}
