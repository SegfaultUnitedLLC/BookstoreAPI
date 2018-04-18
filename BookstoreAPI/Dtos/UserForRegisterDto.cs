using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreAPI.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(24, MinimumLength = 12,
            ErrorMessage = "You must specify a password between 12 and 24 characters.")]
        public string Password { get; set; }
    }
}
