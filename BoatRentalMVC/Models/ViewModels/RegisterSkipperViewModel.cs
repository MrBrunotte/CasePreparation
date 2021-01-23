using System.ComponentModel.DataAnnotations;

namespace BoatRentalMVC.Models.ViewModels
{
    public class RegisterSkipperViewModel
    {
        public int SkipperID { get; set; }

        [Required, StringLength(30, ErrorMessage = "Do not enter more than 30 characters"), Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, StringLength(30, ErrorMessage = "Do not enter more than 30 characters"), Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [StringLength(60, ErrorMessage = "Do not enter more than 60 characters"), Display(Name = "E-mail")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; }

        [Display(Name = "Full name")]
        public string Fullname => $"{FirstName} {LastName}";
    }
}