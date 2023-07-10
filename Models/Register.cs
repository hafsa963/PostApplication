﻿using System.ComponentModel.DataAnnotations;


namespace PostApplication.Models
{
    public class Register
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }
    }
}
