using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryManager.Models
{
    public class Member
    {

        public int MemberId { get; set; }
        [Required(ErrorMessage = "Name must be entered")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Name must be entered")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Telephone number is required")]
        [Display(Name = "Telephone Number")]
        public string TelNo { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email address is required")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [DataType(DataType.PostalCode)]
        [Required(ErrorMessage = "Post code is required")]
        [Display(Name = "Post Code")]
        public string Pcode { get; set; }




    }
}