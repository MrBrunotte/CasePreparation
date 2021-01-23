using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoatRentalMVC.Models.Entities
{
    public class Skipper
    {
        public int Id { get; set; }
        [Required, StringLength(30, ErrorMessage = "Do not enter more than 30 characters"), Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required, StringLength(30, ErrorMessage = "Do not enter more than 30 characters"), Display(Name = "First Name")]
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        [Required, StringLength(60, ErrorMessage = "Do not enter more than 60 characters"), Display(Name = "E-mail")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; }

        // navigation property
        public ICollection<BoatFleet> FleetOfBoats { get; set; }
    }
}
