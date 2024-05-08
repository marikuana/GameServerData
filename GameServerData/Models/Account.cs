using System.ComponentModel.DataAnnotations;

namespace GameServerData.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(64)]
        public string Login { get; set; }
        [Required, MaxLength(64)]
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}