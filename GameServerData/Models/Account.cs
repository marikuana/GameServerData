﻿using System.ComponentModel.DataAnnotations;

namespace GameServerData.Models
{
    public class Account
    {
        [Key]
        public Guid Id { get; set; }
        [Required, MaxLength(64)]
        public string Login { get; set; }
        [Required, MaxLength(64)]
        public string Password { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}