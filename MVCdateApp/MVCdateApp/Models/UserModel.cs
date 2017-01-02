using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCdateApp.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [RegularExpression(@"[a-zA-Z \-]+", ErrorMessage = "Whoops! First name can only contain characters. ")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [RegularExpression(@"[a-zA-Z \-]+", ErrorMessage = "Whoops! Last name can only contain characters. ")]
        public string LastName { get; set; }

        public string FullName
        {
            get { return string.Format(this.FirstName + " " + this.LastName); }
            
        }

        [Display(Name = "Interested in")]
        public bool Sex { get; set; }

        public bool InterestedIn { get; set; }
        public int Age { get; set; }
        public string Image { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string ApplicationUserId { get; set; }
    }
}