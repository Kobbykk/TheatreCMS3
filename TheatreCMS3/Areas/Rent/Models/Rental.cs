using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheatreCMS3.Areas.Rent.Models
{
    public class Rental
    {
        [Key]
        public int RentalId { get; set; }
        [Display(Name = "Rental Name")]
        public string RentalName { get; set; }
        [Display(Name = "Rental Cost")]
        public int RentalCost { get; set; }
        [Display(Name = "Flaws and Damages")]
        public string FlawsAndDamages { get; set; }
    }

    public class RentalEquipment : Rental
    {
        [Display(Name = "Choking Hazard")]
        public bool ChokingHazard { get; set; }
        [Display(Name = "Suffocation Hazard")]
        public bool SuffocationHazard { get; set; }
        [Display(Name = "Purchase Price")]
        public int PurchasePrice { get; set; }

    }

    public class RentalRoom : Rental
    {
        [Display(Name = "Room Number")]
        public int RoomNumber { get; set; }
        [Display(Name = "Square Footage")]
        public int SquareFootage { get; set; }
        [Display(Name = "Max Occupany")]
        public int MaxOccupancy { get; set; }
    }

}