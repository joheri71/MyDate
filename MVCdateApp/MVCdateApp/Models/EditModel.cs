using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCdateApp.Models
{
    public class EditModel
    {
        [Required(ErrorMessage = "First name is required")]
        [RegularExpression(@"[a-zA-Z \-]+", ErrorMessage = "Whoops! First name can only contain characters. ")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [RegularExpression(@"[a-zA-Z \-]+", ErrorMessage = "Whoops! Last name can only contain characters. ")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "We need to know what city you're from.")]
        [RegularExpression(@"[a-zA-Z \-]+", ErrorMessage = "Whoops! City can only contain characters. ")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "We need to know what country you're from.")]
        [RegularExpression(@"[a-zA-Z \-]+", ErrorMessage = "Whoops! Country can only contain characters. ")]
        [Display(Name = "Country")]
        public string Country { get; set; }


    }
}