using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReadyPlayerOne.Models
{
    public class Party
    {
        [Key]
        public int PartyId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string PartyName { get; set; } = string.Empty;

        public List<Player> Players { get; set; } = new List<Player>();
    }
}
