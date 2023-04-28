﻿using System.ComponentModel.DataAnnotations;

namespace SalesOrdersApp.Models.ViewModels
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Please enter a username")]
        [StringLength(255)]
        public string Username { get; set; } = null!;


        [Required(ErrorMessage = "Please enter a first name.")]
        [StringLength(255)]
        public string Firstname { get; set; } = string.Empty;

		[Required(ErrorMessage = "Please enter a last name.")]
		[StringLength(255)]
		public string Lastname { get; set; } = string.Empty;


        [Required(ErrorMessage ="Please enter an email address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

		[Required(ErrorMessage ="Please enter a password")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; } = null!;


        [Required(ErrorMessage ="Please confirm your password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
