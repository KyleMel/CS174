using System.ComponentModel.DataAnnotations;

namespace ReadyPlayerOne.Models
{
    public class Player
    {
        // EF Core will configure the database to generate this value.

        //I got an error before so now I specify the key with [Key].
        [Key] public int PlayerId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string PlayerName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please choose a class.")]
        public string? Class { get; set; }

        [Required(ErrorMessage = "Please enter a Health score.")]
        public int? Health { get; set; }

        [Required(ErrorMessage = "Please enter a Strength score.")]
        public int? Strength { get; set; }

        [Required(ErrorMessage = "Please enter a the players intelligence.")]
        public int? Intelligence { get; set; }

        [Required(ErrorMessage = "Please enter a players Stamina.")]
        public int? Stamina { get; set; }

        [Required(ErrorMessage = "Please enter the players Stealth.")]
        public int? Stealth { get; set; }

        [Required(ErrorMessage = "Please enter an Luck score.")]
        public int? Luck { get; set; }

        [Required(ErrorMessage = "Please choose a morality from the dropdown.")]
        public string? Alignment { get; set; }
    }
}
