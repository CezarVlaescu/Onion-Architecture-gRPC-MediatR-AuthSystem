using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Dtos.Auth
{
    public class RegisterDto
    {
        [Required]
        public string? Username { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [StringLength(100, MinimumLength =6)]
        public string? Password { get; set; }

        [Required]
        public string? Firstname { get; set; }

        [Required]
        public string? Lastname { get; set; }    
    }
}
