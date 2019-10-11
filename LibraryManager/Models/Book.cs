using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace LibraryManager.Models
{
    public class Book
    {
        
        public int BookId { get; set; }

        [Required(ErrorMessage = "Book name must be entered")]
        [Display(Name = "Book Name")]
        [StringLength(70,MinimumLength = 1, ErrorMessage = "Book name must be between 1 and 70 characters")]
        public string BookName { get; set; }
        [Required(ErrorMessage = "Book description must be entered")]
        [Display(Name = "Book Description")]
        [StringLength(120, MinimumLength = 10, ErrorMessage = "Book description must be between 10 and 120 characters")]
        public string Description { get; set; }
        public char Status { get; set; }

    }
}