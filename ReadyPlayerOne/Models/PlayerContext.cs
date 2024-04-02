using Microsoft.EntityFrameworkCore;

namespace ReadyPlayerOne.Models
{
    public class PlayerContext : DbContext
    {
        public PlayerContext(DbContextOptions<PlayerContext> options)
           : base(options)
        { }
        public DbSet<Player> Players { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    PlayerId = 1,
                    PlayerName = "Esther Ulrick",
                    Class = "Mage",
                    Health = 3,
                    Strength = 2,
                    Intelligence = 9,
                    Stamina = 3,
                    Stealth = 6,
                    Luck = 8,
                    Alignment = "True Neutral"
                },

                new Player
                {
                    PlayerId = 2,
                    PlayerName = "Rhiordan Tannick",
                    Class = "Warrior",
                    Health = 8,
                    Strength = 3,
                    Intelligence = 2,
                    Stamina = 8,
                    Stealth = 2,
                    Luck = 2,
                    Alignment = "Lawful Good"
                },
                new Player
                {
                    PlayerId = 3,
                    PlayerName = "Bevil Starling",
                    Class = "Rogue",
                    Health = 6,
                    Strength = 5,
                    Intelligence = 7,
                    Stamina = 5,
                    Stealth = 9,
                    Luck = 7,
                    Alignment = "Chaotic Neutral"

                }

        );


        }
    }
}
