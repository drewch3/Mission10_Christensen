// drew section 3 mission 10

using System.ComponentModel.DataAnnotations;

namespace BowlingAPI.Models
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }
        public string? TeamName { get; set; }
    }
}
