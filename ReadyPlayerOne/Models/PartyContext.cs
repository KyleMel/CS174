using Microsoft.EntityFrameworkCore;

namespace ReadyPlayerOne.Models
{
    public class PartyContext : DbContext
    {
        public PartyContext(DbContextOptions<PartyContext> options) : base(options)
        {
        }

        public DbSet<Party>? Parties { get; set; }
        public DbSet<Player>? Players { get; set; }
    }
}
