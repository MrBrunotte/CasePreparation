using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BoatRentalMVC.Models.Entities
{
    public class BoatFleet
    {
        // ID property
        public int Id { get; set; }

        public int BoatTypId { get; set; }

        // Regular properties
        [Required, StringLength(30, ErrorMessage = "Do not enter more than 30 characters"), Display(Name = "Boat Type")]
        public string TypeOfBoat { get; set; }

        [Required, StringLength(30, ErrorMessage = "Do not enter more than 30 characters"), Display(Name = "Boat Length")]
        public int BoatLength { get; set; }
        // Time property

        [Display(Name = "Time of Docking/Arrival")]
        public DataType ArrivalTime { get; set; }
        // Navigation properties
        public ICollection<Docked> Docked { get; set; }

    }
}