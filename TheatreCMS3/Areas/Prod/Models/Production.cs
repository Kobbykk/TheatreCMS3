using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheatreCMS3.Areas.Prod.Models
{
    public class Production
    {
        public int ProductionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Playwright { get; set; }
        public int Runtime { get; set; }
        [Display(Name = "Opening Day")]
        public DateTime OpeningDay { get; set; }
        [Display(Name = "Closing Day")]
        public DateTime ClosingDay { get; set; }
        [Display(Name = "ShowTime Eve")]
        public DateTime ShowTimeEve { get; set; }
        [Display(Name = "ShowTime Mat")]
        public DateTime? ShowTimeMat { get; set; }  // Nullable
        public int Season { get; set; }
        public bool IsWorldPremiere { get; set; }
        [Display(Name = "Ticket Link")]
        public string TicketLink { get; set; }

        // Method to check if the production is currently showing
        public bool IsCurrentlyShowing()
        {
            var currentDate = DateTime.Now;
            return currentDate >= OpeningDay && currentDate <= ClosingDay;
        }
    }
}